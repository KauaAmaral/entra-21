namespace Entra21.BancoDadosExercicio01.Ado.Net.Views.Cidades
{
    partial class CidadeCadastroEdicaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxUnidadeFederativa = new System.Windows.Forms.ComboBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelUnidadeFederativa = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelQuantidadeHabitantes = new System.Windows.Forms.Label();
            this.textBoxQuantidadeHabitantes = new System.Windows.Forms.TextBox();
            this.labelDataHoraFundacao = new System.Windows.Forms.Label();
            this.labelPib = new System.Windows.Forms.Label();
            this.dateTimePickerDataHoraFundacao = new System.Windows.Forms.DateTimePicker();
            this.textBoxPib = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(345, 313);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(264, 313);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxUnidadeFederativa
            // 
            this.comboBoxUnidadeFederativa.DisplayMember = "Nome";
            this.comboBoxUnidadeFederativa.FormattingEnabled = true;
            this.comboBoxUnidadeFederativa.Location = new System.Drawing.Point(12, 89);
            this.comboBoxUnidadeFederativa.Name = "comboBoxUnidadeFederativa";
            this.comboBoxUnidadeFederativa.Size = new System.Drawing.Size(408, 23);
            this.comboBoxUnidadeFederativa.TabIndex = 10;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(408, 23);
            this.textBoxNome.TabIndex = 8;
            // 
            // labelUnidadeFederativa
            // 
            this.labelUnidadeFederativa.AutoSize = true;
            this.labelUnidadeFederativa.Location = new System.Drawing.Point(12, 71);
            this.labelUnidadeFederativa.Name = "labelUnidadeFederativa";
            this.labelUnidadeFederativa.Size = new System.Drawing.Size(108, 15);
            this.labelUnidadeFederativa.TabIndex = 6;
            this.labelUnidadeFederativa.Text = "Unidade Federativa";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 12);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 7;
            this.labelNome.Text = "Nome";
            // 
            // labelQuantidadeHabitantes
            // 
            this.labelQuantidadeHabitantes.AutoSize = true;
            this.labelQuantidadeHabitantes.Location = new System.Drawing.Point(12, 132);
            this.labelQuantidadeHabitantes.Name = "labelQuantidadeHabitantes";
            this.labelQuantidadeHabitantes.Size = new System.Drawing.Size(145, 15);
            this.labelQuantidadeHabitantes.TabIndex = 7;
            this.labelQuantidadeHabitantes.Text = "Quantidade de Habitantes";
            // 
            // textBoxQuantidadeHabitantes
            // 
            this.textBoxQuantidadeHabitantes.Location = new System.Drawing.Point(12, 150);
            this.textBoxQuantidadeHabitantes.Name = "textBoxQuantidadeHabitantes";
            this.textBoxQuantidadeHabitantes.Size = new System.Drawing.Size(408, 23);
            this.textBoxQuantidadeHabitantes.TabIndex = 8;
            // 
            // labelDataHoraFundacao
            // 
            this.labelDataHoraFundacao.AutoSize = true;
            this.labelDataHoraFundacao.Location = new System.Drawing.Point(12, 194);
            this.labelDataHoraFundacao.Name = "labelDataHoraFundacao";
            this.labelDataHoraFundacao.Size = new System.Drawing.Size(117, 15);
            this.labelDataHoraFundacao.TabIndex = 7;
            this.labelDataHoraFundacao.Text = "Data/Hora Fundação";
            // 
            // labelPib
            // 
            this.labelPib.AutoSize = true;
            this.labelPib.Location = new System.Drawing.Point(12, 256);
            this.labelPib.Name = "labelPib";
            this.labelPib.Size = new System.Drawing.Size(24, 15);
            this.labelPib.TabIndex = 7;
            this.labelPib.Text = "Pib";
            // 
            // dateTimePickerDataHoraFundacao
            // 
            this.dateTimePickerDataHoraFundacao.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePickerDataHoraFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataHoraFundacao.Location = new System.Drawing.Point(12, 221);
            this.dateTimePickerDataHoraFundacao.Name = "dateTimePickerDataHoraFundacao";
            this.dateTimePickerDataHoraFundacao.Size = new System.Drawing.Size(408, 23);
            this.dateTimePickerDataHoraFundacao.TabIndex = 14;
            // 
            // textBoxPib
            // 
            this.textBoxPib.Location = new System.Drawing.Point(12, 274);
            this.textBoxPib.Name = "textBoxPib";
            this.textBoxPib.Size = new System.Drawing.Size(408, 23);
            this.textBoxPib.TabIndex = 16;
            // 
            // CidadeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 347);
            this.Controls.Add(this.textBoxPib);
            this.Controls.Add(this.dateTimePickerDataHoraFundacao);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxUnidadeFederativa);
            this.Controls.Add(this.labelPib);
            this.Controls.Add(this.textBoxQuantidadeHabitantes);
            this.Controls.Add(this.labelDataHoraFundacao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelQuantidadeHabitantes);
            this.Controls.Add(this.labelUnidadeFederativa);
            this.Controls.Add(this.labelNome);
            this.Name = "CidadeCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CidadeCadastroEdicaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonCancelar;
        private ComboBox comboBoxUnidadeFederativa;
        private TextBox textBoxNome;
        private Label labelUnidadeFederativa;
        private Label labelNome;
        private Label labelQuantidadeHabitantes;
        private TextBox textBoxQuantidadeHabitantes;
        private Label labelDataHoraFundacao;
        private Label labelPib;
        private DateTimePicker dateTimePickerDataHoraFundacao;
        private TextBox textBoxPib;
    }
}