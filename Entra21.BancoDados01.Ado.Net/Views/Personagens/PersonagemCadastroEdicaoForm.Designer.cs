namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    partial class PersonagemCadastroEdicaoForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEditora = new System.Windows.Forms.Label();
            this.labelTipoPersonagem = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxEditora = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoPersonagem = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(25, 22);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelEditora
            // 
            this.labelEditora.AutoSize = true;
            this.labelEditora.Location = new System.Drawing.Point(25, 81);
            this.labelEditora.Name = "labelEditora";
            this.labelEditora.Size = new System.Drawing.Size(44, 15);
            this.labelEditora.TabIndex = 1;
            this.labelEditora.Text = "Editora";
            // 
            // labelTipoPersonagem
            // 
            this.labelTipoPersonagem.AutoSize = true;
            this.labelTipoPersonagem.Location = new System.Drawing.Point(27, 144);
            this.labelTipoPersonagem.Name = "labelTipoPersonagem";
            this.labelTipoPersonagem.Size = new System.Drawing.Size(99, 15);
            this.labelTipoPersonagem.TabIndex = 1;
            this.labelTipoPersonagem.Text = "Tipo Personagem";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(25, 40);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(408, 23);
            this.textBoxNome.TabIndex = 2;
            // 
            // comboBoxEditora
            // 
            this.comboBoxEditora.FormattingEnabled = true;
            this.comboBoxEditora.Location = new System.Drawing.Point(25, 99);
            this.comboBoxEditora.Name = "comboBoxEditora";
            this.comboBoxEditora.Size = new System.Drawing.Size(408, 23);
            this.comboBoxEditora.TabIndex = 3;
            // 
            // comboBoxTipoPersonagem
            // 
            this.comboBoxTipoPersonagem.DisplayMember = "Tipo";
            this.comboBoxTipoPersonagem.FormattingEnabled = true;
            this.comboBoxTipoPersonagem.Location = new System.Drawing.Point(25, 162);
            this.comboBoxTipoPersonagem.Name = "comboBoxTipoPersonagem";
            this.comboBoxTipoPersonagem.Size = new System.Drawing.Size(408, 23);
            this.comboBoxTipoPersonagem.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(277, 208);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(358, 208);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // PersonagemCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 258);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxTipoPersonagem);
            this.Controls.Add(this.comboBoxEditora);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelTipoPersonagem);
            this.Controls.Add(this.labelEditora);
            this.Controls.Add(this.labelNome);
            this.Name = "PersonagemCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonagemCadastroEdicaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label labelNome;
        private Label labelEditora;
        private Label labelTipoPersonagem;
        private TextBox textBoxNome;
        private ComboBox comboBoxEditora;
        private ComboBox comboBoxTipoPersonagem;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}