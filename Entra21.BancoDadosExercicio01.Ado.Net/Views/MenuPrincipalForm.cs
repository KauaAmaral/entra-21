using Entra21.BancoDadosExercicio01.Ado.Net.Views.Cidades;
using Entra21.BancoDadosExercicio01.Ado.Net.Views.UnidadesFederativas;

namespace Entra21.BancoDadosExercicio01.Ado.Net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonUnidadeFederativa_Click(object sender, EventArgs e)
        {
            var unidadeFederativa = new UnidadeFederativaListagemForm();

            unidadeFederativa.ShowDialog();
        }

        private void buttonCidades_Click(object sender, EventArgs e)
        {
            var cidade = new CidadeListagemForm();

            cidade.ShowDialog();
        }
    }
}
