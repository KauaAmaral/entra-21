namespace Entra21.ExemplosWindowsForms.Exemplo01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.buttonEnderecos = new System.Windows.Forms.Button();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnderecos
            // 
            this.buttonEnderecos.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnderecos.Image")));
            this.buttonEnderecos.Location = new System.Drawing.Point(10, 12);
            this.buttonEnderecos.Name = "buttonEnderecos";
            this.buttonEnderecos.Size = new System.Drawing.Size(190, 186);
            this.buttonEnderecos.TabIndex = 0;
            this.buttonEnderecos.Text = "Endereços";
            this.buttonEnderecos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEnderecos.UseVisualStyleBackColor = true;
            this.buttonEnderecos.Click += new System.EventHandler(this.buttonEnderecos_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonPacientes.Image")));
            this.buttonPacientes.Location = new System.Drawing.Point(206, 12);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(177, 186);
            this.buttonPacientes.TabIndex = 1;
            this.buttonPacientes.Text = "Pacientes";
            this.buttonPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPacientes.UseVisualStyleBackColor = true;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 207);
            this.Controls.Add(this.buttonPacientes);
            this.Controls.Add(this.buttonEnderecos);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEnderecos;
        private Button buttonPacientes;
    }
}