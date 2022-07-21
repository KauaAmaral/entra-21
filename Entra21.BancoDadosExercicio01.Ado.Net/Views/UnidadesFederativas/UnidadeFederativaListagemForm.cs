using Entra21.BancoDadosExercicio01.Ado.Net.Services;

namespace Entra21.BancoDadosExercicio01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaListagemForm : Form
    {
        private UnidadeFederativaService unidadeFederativaService;

        public UnidadeFederativaListagemForm()
        {
            InitializeComponent();

            unidadeFederativaService = new UnidadeFederativaService();
        }

        private void AtualizarRegistroDataGridView()
        {
            var unidadesFederativas = unidadeFederativaService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    unidadeFederativa.Id,
                    unidadeFederativa.Nome,
                    unidadeFederativa.Sigla
                });
            }
        }

        private void UnidadeFederativaListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistroDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var unidadeFederativaCadastroEdicaoForm = new UnidadeFederativaCadastroEdicaoForm();

            unidadeFederativaCadastroEdicaoForm.ShowDialog();

            AtualizarRegistroDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            unidadeFederativaService.Apagar(id);

            AtualizarRegistroDataGridView();

            MessageBox.Show("Registro apagado com sucesso!");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma unidade federativa");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var unidadeFederativa = unidadeFederativaService.ObterPorId(id);

            var unidadeFederativaForm = new UnidadeFederativaCadastroEdicaoForm(unidadeFederativa);

            unidadeFederativaForm.ShowDialog();

            AtualizarRegistroDataGridView();
        }
    }
}
