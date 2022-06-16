﻿using System;
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
        private int codigo = 1;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            // Calcular IMC
            var imc = peso / (altura * altura);

            // Verificar se esta em modo de edição
            if (indiceLinhaSelecionada == -1)
            {
            // Adicionar linha no dataGridView de paciente
            dataGridViewTabelaImc.Rows.Add(new object[]
            {
                codigo++, nome, altura, peso, imc
            });

                return;
            }

            dataGridViewTabelaImc.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridViewTabelaImc.Rows[indiceLinhaSelecionada].Cells[2].Value = altura;
            dataGridViewTabelaImc.Rows[indiceLinhaSelecionada].Cells[3].Value = peso;
            dataGridViewTabelaImc.Rows[indiceLinhaSelecionada].Cells[4].Value = imc;

        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Pegar o indice da linha selecionada
            var indiceLinhaSelecionada = dataGridViewTabelaImc.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecionar um paciente");
                return;
            }

            var opcaoEscolhida = MessageBox.Show(
                "Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Verificar se o usuario escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                // Remove a linha utilizando o indice da DateGridView
                dataGridViewTabelaImc.Rows.RemoveAt(indiceLinhaSelecionada);
            }
        }

        private void PacientesForm_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridViewTabelaImc.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == 1)
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
    }
}
