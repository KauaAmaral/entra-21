using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private List<Paciente> pacientes;

        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;

        public PacientesForm()
        {
            InitializeComponent();

            // Cria uma lista de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();

            // Ler do arquivo JSON os pacientes cadastrados anteriormente
            LerArquivoApresentandoPacientes();
        }

        private void PacientesForm_Load_1(object sender, EventArgs e)
        {

        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            textBoxPeso.Text = "";
            textBoxNome.Text = "";
            textBoxAltura.Text = "";

            indiceLinhaSelecionada = -1;

            dataGridViewTabelaImc.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            // Calcular IMC
            var imc = CalcularImc(peso, altura);

            // Verificar se esta em modo de edição
            if (indiceLinhaSelecionada == 0)
            {
                // Adicionar linha no dataGridView de paciente
                dataGridViewTabelaImc.Rows.Add(new object[]
                {
                ++codigo, nome, altura, peso, imc
                });
                AdicionarPacienteSalvandoNoArquivo(codigo, nome, peso, altura);

                return;
            }

            dataGridViewTabelaImc.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridViewTabelaImc.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridViewTabelaImc.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridViewTabelaImc.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

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
                var indiceLinhaSelecionada = dataGridViewTabelaImc.SelectedRows[0].Index;

                // Remove a linha utilizando o indice da DateGridView
                dataGridViewTabelaImc.Rows.RemoveAt(indiceLinhaSelecionada);

                // Remove o paciente da lista de pacientes
                pacientes.RemoveAt(indiceLinhaSelecionada);

                // Atualizar o arquivo com lista de pacientes sem o paciente removido
                SalvarEmArquivo();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridViewTabelaImc.SelectedRows.Count;

            if (indiceLinhaSelecionada == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            // Obter a linha que o usuario selecionou
            var linhaSelecionada = dataGridViewTabelaImc.SelectedRows[0];

            // Obter a informação da linha selecionada passado a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[indiceLinhaSelecionada].Nome = nome;
            pacientes[indiceLinhaSelecionada].Peso = peso;
            pacientes[indiceLinhaSelecionada].Altura = altura;

            SalvarEmArquivo();

            LimparCampos();
        }

        private void AdicionarPacienteSalvandoNoArquivo(int codigo, string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = codigo,
                Nome = nome,
                Altura = altura,
                Peso = peso
            };
            // var paciente = new Paciente();
            // paciente.Codigo = codigo;
            // paciente.Nome = nome;

            pacientes.Add(paciente);

            SalvarEmArquivo();

            LimparCampos();
        }

        private void SalvarEmArquivo()
        {
            // Converter uma lista de objetos em uma string contendo o JSON
            var pacientesJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.json";
            // Salvar a string contendo o JSON em um arquivo no formato JSON
            File.WriteAllText(caminho, pacientesJson);
        }

        private double CalcularImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }

        private void LerArquivoApresentandoPacientes()
        {
            // Validar se arquivo não existe, consequentemente nao e necessario percorrer uma lista que nao existe
            if (File.Exists("pacientes.json") == false)
                return;

            // Ler arquivo json e armzenar os pacientes na lista de pacientes
            var conteudoArquivo = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);

            // Criar uma variavel para armazenar o codigo do ultimo produto, para quando cadastrar um novo armazenar com o codigo correto
            var maiorCodigo = int.MinValue;

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
                    CalcularImc(paciente.Peso, paciente.Altura)
                });

                // Rotina para descobrir o paciente com o maior codigo
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;

                // Validar se conseguiu encontrar algum codigo, caso contrario nao deve atualizar o codigo do novo paciente
                if (maiorCodigo != int.MinValue)
                    codigo = maiorCodigo;
            }
        }
    }
}
