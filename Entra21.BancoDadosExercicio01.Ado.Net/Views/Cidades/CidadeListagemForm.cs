using Entra21.BancoDadosExercicio01.Ado.Net.Services;

namespace Entra21.BancoDadosExercicio01.Ado.Net.Views.Cidades
{
    public partial class CidadeListagemForm : Form
    {
        private readonly CidadeService _cidadeService;

        public CidadeListagemForm()
        {
            InitializeComponent();

            _cidadeService = new CidadeService();

            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var cidades = _cidadeService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < cidades.Count; i++)
            {
                var cidade = cidades[i];

                dataGridView1.Rows.Add(new object[]
                {
                    cidade.Id,
                    cidade.Nome,
                    cidade.UnidadeFederativa.Nome,
                    cidade.UnidadeFederativa.Sigla,
                    cidade.QuantidadeHabitantes,
                    cidade.DataHoraFundacao,
                    cidade.Pib
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cidadeForm = new CidadeCadastroEdicaoForm();
            cidadeForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione alguma cidade");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var cidade = _cidadeService.ObterPorId(id);

            var cidadeCadastroEdicaoForm = new CidadeCadastroEdicaoForm(cidade);
            cidadeCadastroEdicaoForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _cidadeService.Apagar(id);

            PreencherDataGridView();

            MessageBox.Show("Registro removido com sucesso!");
        }
    }
}
