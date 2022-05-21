namespace PVendas
{
    partial class frmPVendas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lstbxDados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(281, 200);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lstbxDados
            // 
            this.lstbxDados.FormattingEnabled = true;
            this.lstbxDados.Location = new System.Drawing.Point(428, 83);
            this.lstbxDados.Name = "lstbxDados";
            this.lstbxDados.Size = new System.Drawing.Size(293, 225);
            this.lstbxDados.TabIndex = 2;
            // 
            // frmPVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxDados);
            this.Controls.Add(this.btnVerificar);
            this.Name = "frmPVendas";
            this.Text = "PVendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.ListBox lstbxDados;
    }
}

