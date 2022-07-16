using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;

        public TipoPersonagemListagemForm()
        {
            InitializeComponent();

            // Instanciado objeto da classe TipoPersonagemService para permitir:
            // - Listar todos
            // - Editar
            // - Apagar
            tipoPersonagemService = new TipoPersonagemService();
        }

        private void TipoPersonagemListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistroDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicaoForm = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastroEdicaoForm.ShowDialog();

            AtualizarRegistroDataGridView();
        }

        private void AtualizarRegistroDataGridView()
        {
            // Obter todos os personagens cadastrados na tabela tipo_personagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            // Removido todos os registros do dataGridView1
            dataGridView1.Rows.Clear();

            // Percorrido todos os registros do dataGridView permitindo o usuario visualiza-los
            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistroDataGridView();

            MessageBox.Show("Registro apagado com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastrar algum tipo de personagem");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            // Obter a linha selecionada
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter o id da linha selecionada
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Obter o banco de dados o tipo de personagem selecionado
            var tipoPersonagem = tipoPersonagemService.ObterPorId(id);

            // Instanciado objeto do form para permitir edicao passando o tipo personagem, que permitira preencher os campos com os dados do banco de dados
            var tipoPersonagemForm = new TipoPersonagemCadastroEdicaoForm(tipoPersonagem);
            // Apresentado o form para o usuario
            tipoPersonagemForm.ShowDialog();

            AtualizarRegistroDataGridView();
        }
    }
}
