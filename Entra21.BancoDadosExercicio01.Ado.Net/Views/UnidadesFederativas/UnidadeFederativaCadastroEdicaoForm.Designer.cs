namespace Entra21.BancoDadosExercicio01.Ado.Net.Views.UnidadesFederativas
{
    partial class UnidadeFederativaCadastroEdicaoForm
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNomeUnidadeFederativa = new System.Windows.Forms.Label();
            this.labelSigla = new System.Windows.Forms.Label();
            this.textBoxSigla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(294, 107);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(213, 107);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(14, 25);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(355, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // labelNomeUnidadeFederativa
            // 
            this.labelNomeUnidadeFederativa.AutoSize = true;
            this.labelNomeUnidadeFederativa.Location = new System.Drawing.Point(14, 7);
            this.labelNomeUnidadeFederativa.Name = "labelNomeUnidadeFederativa";
            this.labelNomeUnidadeFederativa.Size = new System.Drawing.Size(144, 15);
            this.labelNomeUnidadeFederativa.TabIndex = 3;
            this.labelNomeUnidadeFederativa.Text = "Nome Unidade Federativa";
            // 
            // labelSigla
            // 
            this.labelSigla.AutoSize = true;
            this.labelSigla.Location = new System.Drawing.Point(14, 60);
            this.labelSigla.Name = "labelSigla";
            this.labelSigla.Size = new System.Drawing.Size(32, 15);
            this.labelSigla.TabIndex = 3;
            this.labelSigla.Text = "Sigla";
            // 
            // textBoxSigla
            // 
            this.textBoxSigla.Location = new System.Drawing.Point(14, 78);
            this.textBoxSigla.Name = "textBoxSigla";
            this.textBoxSigla.Size = new System.Drawing.Size(355, 23);
            this.textBoxSigla.TabIndex = 4;
            // 
            // UnidadeFederativaCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 139);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxSigla);
            this.Controls.Add(this.labelSigla);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNomeUnidadeFederativa);
            this.Name = "UnidadeFederativaCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro / Edição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonCancelar;
        private TextBox textBoxNome;
        private Label labelNomeUnidadeFederativa;
        private Label labelSigla;
        private TextBox textBoxSigla;
    }
}