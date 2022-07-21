using Entra21.BancoDadosExercicio01.Ado.Net.Models;
using Entra21.BancoDadosExercicio01.Ado.Net.Services;

namespace Entra21.BancoDadosExercicio01.Ado.Net.Views.Cidades
{
    public partial class CidadeCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public CidadeCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxUnidadeFederativa();

            _idParaEditar = -1;
        }

        private void PreencherComboBoxUnidadeFederativa()
        {
            var unidadeFederativaService = new UnidadeFederativaService();

            var unidadesFederativas = unidadeFederativaService.ObterTodos();

            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];

                comboBoxUnidadeFederativa.Items.Add(unidadeFederativa);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxUnidadeFederativa.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Unidade Federativa");
                return;
            }

            var nome = textBoxNome.Text.Trim();

            var unidadeFederativa = comboBoxUnidadeFederativa.SelectedItem as UnidadeFederativa;

            var quantidadeHabitantes = textBoxQuantidadeHabitantes.Text.Trim();

            var dataHoraFundacao = dateTimePickerDataHoraFundacao.Value;

            // Verificar na proxima aula
            var pib = maskedTextBoxPib.Text.Trim();

            var cidade = new Cidade();
            cidade.Nome = nome;
            cidade.UnidadeFederativa = unidadeFederativa;
            cidade.QuantidadeHabitantes = Convert.ToInt32(quantidadeHabitantes);
            cidade.DataHoraFundacao = dataHoraFundacao;
            cidade.Pib = Convert.ToDecimal(pib);

            var cidadeService = new CidadeService();

            if (_idParaEditar == -1)
            {
                cidadeService.Cadastrar(cidade);

                MessageBox.Show("Cidade cadastrada com sucesso!");
                Close();
            }
            else
            {
                cidade.Id = _idParaEditar;

                cidadeService.Ediatr(cidade);

                MessageBox.Show("Cidade alterada com sucesso!");
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
