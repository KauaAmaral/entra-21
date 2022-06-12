using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;
        private PacienteServico pacienteServico;

        // Construtor: construir o objeto que esta sende instanciado com as devidas informacoes ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            // Instanciado o objeto de PacienteServico o permitira lista os pacientes no ComboBox e decorrente disso sera possivel o usuario selecionar o mesmo
            pacienteServico = new PacienteServico();

            // Deve apresentar os dados quando a tela for carregada
            PreencherDataGridViewComEnderecos();

            // ira preencher o Combox(campo de selecao) com os pacientes
            PreencherComboBoxComNomesDosPacientes();

            ObterDadosCep();
        }

        private void PreencherComboBoxComNomesDosPacientes()
        {
            // Obter lista dos pacientes que foram cadastrados, ou seja, armazenados no JSON
            var pacientes = pacienteServico.ObterTodos();

            // Percorrer todos os pacientes adicionando no ComboBox
            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;

            dataGridView1.ClearSelection();
        }

        private void buttonSlavar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuario armazenando em variaveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            // Executar o metodo ValidarDados que retornara um bool sendo true quando os dados forem validos / false quando os dados forem invalidos
            var dadosvaValidos = ValidarDados(cep, enderecoCompleto, nomePaciente);

            // Validar se os dados sao validos para n dar coontinuidade no cadastro do endereco
            if (dadosvaValidos == false)
            {
                return;
            }

            // Verificar senao esta em edicao, ou seja modo de cadastro
            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarEndereco(cep, enderecoCompleto, nomePaciente);
            else
                EditarEndereco(cep, enderecoCompleto, nomePaciente);

            // Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();

            LimparCampos();
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string nomePaciente)
        {
            // Obter linha selecionada
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter codigo que esta na coluna do DataGridView
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Construir o objeto com os dados da tela
            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Atualizar o dado na linha de endereco e salvar o dado atualizado no arquivo JSON
            enderecoServico.Editar(endereco);
        }

        private void CadastrarEndereco(string cep, string enderecoCompleto, string? nomePaciente)
        {
            // Construir o objeto de endereco com as variaveis
            var endereco = new Endereco();
            endereco.Codigo = enderecoServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Salvar este endereco na lista de enderecos e no arquivo JSON
            enderecoServico.Adicionar(endereco);
        }

        private void PreencherDataGridViewComEnderecos()
        {
            // Obter todos os enderecos da lista de endeerecos
            var enderecos = enderecoServico.ObterTodos();

            // Remover todas as linhas do dataGridView
            dataGridView1.Rows.Clear();


            // Percorrer cada um dos enderecos adicionando uma nova linha na tabela
            for(var i = 0; i < enderecos.Count; i++)
            {
                // Obter endereco percorrido
                var endereco = enderecos[i];

                // Ciar uma nova linha do DataGridView com os dados referentes ao endereco
                dataGridView1.Rows.Add(new object[]
                {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });
            }
            // Remover a selecao do dataGridView
            dataGridView1.ClearSelection();
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "");

            if (cep.Length != 8)
            {
                return;
            }

            // HttpClient permite fazer requisicoes para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisicao para o site ViaCep para obter os dados do endereco do cep
            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            // Verificar se a requisicao deu certo
            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Obter a respostas da requisicao
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text = $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }

        // Sera executado este 
        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private bool ValidarDados(string cep, string enderecoCompleto, string nomePaciente)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP invalido");

                maskedTextBoxCep.Focus();

                return false;
            }

            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("Endereço cpmpleto de conter no minimo 10 caracteres");

                textBoxEnderecoCompleto.Focus();

                return false;
            }

            if (comboBoxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um paciente");

                comboBoxPaciente.DroppedDown = true;

                return false;
            }

            return true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Verificar se algum tem do DataGridView esta selecionado
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereco para remover");

                return;
            }

            //Questionar se o usuario realmente deseja apagar
            var resposta = MessageBox.Show("Deseja realmente apagar o endereço?", "Aviso",
                MessageBoxButtons.YesNo);

            //Validar que o usuario nao escolheu Sim, pq n deve continuar executando o codigo abaixo
            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa teu registro ta ali salvo");

                    return;
            }

            // Qual item sera apagado
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter codigo da linha selecionada na primeira coluna, que n esta sendo apresentada para o usuario que e referente ao codigo do endereco
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Apagar o item da lista de itens no servico
            // Atualizar o arquivo JSON

            // Buscar o endereco da lsita de enderecos por codigo
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            // Apagar o endereco encontrado da lista de enderecos e atualizar o arquivo JSON
            enderecoServico.Apagar(endereco);

            // Atualizar o DataGridView
            PreencherDataGridViewComEnderecos();

            // Remover a selecao do DataGridView
            dataGridView1.ClearSelection();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentaDadosParaEdicao();
        }

        private void ApresentaDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereco para ediatar");

                return;
            }

            // Obter a lina que o usuario selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter o codigo do endereco que o usuario selecionou
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Obter o endereco escolhido
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            // Apresentar os dados do endereco na tela para edicao
            maskedTextBoxCep.Text = endereco.Cep;
            textBoxEnderecoCompleto.Text = endereco.EnderecoCompleto;
            comboBoxPaciente.SelectedItem = endereco.Paciente.Nome;
        }

        // Quando o formularo é carregado apresenta os dados do DataGridView
        private void EnderecosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentaDadosParaEdicao();
        }
    }
}
