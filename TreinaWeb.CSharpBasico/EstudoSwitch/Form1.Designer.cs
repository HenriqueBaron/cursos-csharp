namespace EstudoSwitch
{
    partial class frmSwitch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnVerificarNumero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número a ser verificado:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(181, 6);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 22);
            this.txbNumero.TabIndex = 1;
            // 
            // btnVerificarNumero
            // 
            this.btnVerificarNumero.Location = new System.Drawing.Point(287, 6);
            this.btnVerificarNumero.Name = "btnVerificarNumero";
            this.btnVerificarNumero.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarNumero.TabIndex = 2;
            this.btnVerificarNumero.Text = "Verificar";
            this.btnVerificarNumero.UseVisualStyleBackColor = true;
            this.btnVerificarNumero.Click += new System.EventHandler(this.btnVerificarNumero_Click);
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 38);
            this.Controls.Add(this.btnVerificarNumero);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmSwitch";
            this.Text = "TreinaWeb - Estudo do Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Button btnVerificarNumero;
    }
}

