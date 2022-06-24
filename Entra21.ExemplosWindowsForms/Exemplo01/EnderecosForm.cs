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
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;
        }

        private void buttonSlavar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuario armazenando em variaveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            // Construir o objeto de endereco com as variaveis
            var endereco = new Endereco();
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Salvar este endereco na lista de enderecos e no arquivo JSON
            enderecoServico.Adicionar(endereco);

            // Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();
        }

        private void PreencherDataGridViewComEnderecos()
        {
            // Obter todos os enderecos da lista de endeerecos
            var enderecos = enderecoServico.ObterTodos();

            // Remover todas as linhas do dataGridView
            dataGridView1.Rows.Clear();

            // Remover a selecao do dataGridView
            dataGridView1.ClearSelection();

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
        }

        private void ObterDadosCep()
        {
            var cep = "89042299";

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

                textBoxEnderecoCompleto.Text = $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.logradouro}";
            }
        }
    }
}
