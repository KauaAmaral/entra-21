using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private PacienteServico pacienteServico;

        public PacientesForm()
        {
            InitializeComponent();

            // Instanciar um objeto do PacienteServico que e responsavel por gerenciar os dados dos pacientes
            pacienteServico = new PacienteServico();

            // Ler do arquivo JSON os pacientes cadastrados anteriormente
            ListarPacientes();
        }

        private void PacientesForm_Load_1(object sender, EventArgs e)
        {
            ListarPacientes();
        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            textBoxPeso.Clear();
            textBoxNome.Clear();
            textBoxAltura.Clear();

            dataGridViewTabelaImc.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            // Verificar se esta em modo de edição
            if (dataGridViewTabelaImc.SelectedRows.Count == 0)
            {
                AdicionarPaciente(nome, peso, altura);

                return;
            }
            EditarDados(nome, peso, altura);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Obter a quantidade de linhas selecionadas no DataGridView
            var quantidadeLinhasSelecionadas = dataGridViewTabelaImc.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecionar um paciente");
                return;
            }

            var opcaoEscolhida = MessageBox.Show(
                "Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Verificar se o usuario escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                // Obter o codigo do paciente escolhido para apagar
                var linhaSelecionada = dataGridViewTabelaImc.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                // Apaga o paciente da lista de pacientes atalizando o arquivo JSON
                pacienteServico.Apagar(codigoSelecionado);

                ListarPacientes();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTabelaImc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            // Obter a linha que o usuario selecionou
            var linhaSelecionada = dataGridViewTabelaImc.SelectedRows[0];

            // Obter a informação da linha selecionada passado a coluna desejada
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            // Instanciar o paciente com os dados preenchidos na tela para alterar o existente
            var paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Peso = peso;
            paciente.Altura = altura;

            // Obter o codigo do registro escolhido para alterar
            var linhaSelecionada = dataGridViewTabelaImc.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            paciente.Codigo = codigo;

            // Alterar o paciente na lista de pacientes e atualizar o arquvivo JSON
            pacienteServico.Editar(paciente);

            LimparCampos();

            ListarPacientes();
        }

        private void AdicionarPaciente(string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = pacienteServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                Altura = altura,
                Peso = peso
            };
            // var paciente = new Paciente();
            // paciente.Codigo = codigo;
            // paciente.Nome = nome;

            // Adicionar na lista e atualizar o arquivo JSON
            pacienteServico.Cadastrar(paciente);

            LimparCampos();

            ListarPacientes();
        }

        private void ListarPacientes()
        {
            // Obter a lista dos pacientes e listar para o usuario
            var pacientes = pacienteServico.ObterTodos();

            // Remover todos os itens do DataGridView pois sera adicionado novamente
            dataGridViewTabelaImc.Rows.Clear();

            // Percorrer a lista de pacientes
            for (int i = 0; i < pacientes.Count; i++)
            {
                // Obtem o paciente que esta sendo percorrido
                var paciente = pacientes[i];

                // Adicionar o paciente que esta no arquivo json no DataGridViewTableImc
                dataGridViewTabelaImc.Rows.Add(new object[]
                {
                    paciente.Codigo,
                    paciente.Nome,
                    paciente.Altura,
                    paciente.Peso,
                    paciente.ObterImc()
                });
            }
            dataGridViewTabelaImc.ClearSelection();
        }
    }
}
