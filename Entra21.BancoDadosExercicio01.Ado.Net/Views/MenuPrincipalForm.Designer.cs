namespace Entra21.BancoDadosExercicio01.Ado.Net.Views
{
    partial class MenuPrincipalForm
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
            this.buttonCidades = new System.Windows.Forms.Button();
            this.buttonUnidadeFederativa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCidades
            // 
            this.buttonCidades.Location = new System.Drawing.Point(195, 12);
            this.buttonCidades.Name = "buttonCidades";
            this.buttonCidades.Size = new System.Drawing.Size(177, 157);
            this.buttonCidades.TabIndex = 0;
            this.buttonCidades.Text = "Cidades";
            this.buttonCidades.UseVisualStyleBackColor = true;
            // 
            // buttonUnidadeFederativa
            // 
            this.buttonUnidadeFederativa.Location = new System.Drawing.Point(12, 12);
            this.buttonUnidadeFederativa.Name = "buttonUnidadeFederativa";
            this.buttonUnidadeFederativa.Size = new System.Drawing.Size(177, 157);
            this.buttonUnidadeFederativa.TabIndex = 0;
            this.buttonUnidadeFederativa.Text = "Unidade Federativa";
            this.buttonUnidadeFederativa.UseVisualStyleBackColor = true;
            this.buttonUnidadeFederativa.Click += new System.EventHandler(this.buttonUnidadeFederativa_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 179);
            this.Controls.Add(this.buttonUnidadeFederativa);
            this.Controls.Add(this.buttonCidades);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCidades;
        private Button buttonUnidadeFederativa;
    }
}