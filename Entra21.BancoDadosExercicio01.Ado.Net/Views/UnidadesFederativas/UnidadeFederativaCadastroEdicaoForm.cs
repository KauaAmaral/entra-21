using Entra21.BancoDadosExercicio01.Ado.Net.Models;
using Entra21.BancoDadosExercicio01.Ado.Net.Services;

namespace Entra21.BancoDadosExercicio01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaCadastroEdicaoForm : Form
    {
        private int idEdicao = -1;

        public UnidadeFederativaCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public UnidadeFederativaCadastroEdicaoForm(UnidadeFederativa unidadeFederativa) : this()
        {
            idEdicao = unidadeFederativa.Id;

            textBoxNome.Text = unidadeFederativa.Nome;

            textBoxSigla.Text = unidadeFederativa.Sigla;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nomeUnidadeFederativa = textBoxNome.Text.Trim();

            var sigla = textBoxSigla.Text.Trim();

            var unidadeFederativa = new UnidadeFederativa();

            unidadeFederativa.Nome = nomeUnidadeFederativa;
            unidadeFederativa.Sigla = sigla;

            var unidadeFederativaService = new UnidadeFederativaService();

            if (idEdicao == -1)
            {
                unidadeFederativaService.Cadastrar(unidadeFederativa);

                MessageBox.Show("Unidade Federativa Cadastrada com sucesso!");

                Close();

                return;
            }

            unidadeFederativa.Id = idEdicao;

            unidadeFederativaService.Editar(unidadeFederativa);

            MessageBox.Show("Unidade Federativa alterada com sucesso!");

            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
