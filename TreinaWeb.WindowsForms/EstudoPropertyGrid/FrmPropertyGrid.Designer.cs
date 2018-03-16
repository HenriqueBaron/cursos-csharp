namespace EstudoPropertyGrid
{
    partial class FrmPropertyGrid
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
            this.prgAppSettings = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // prgAppSettings
            // 
            this.prgAppSettings.LineColor = System.Drawing.SystemColors.ControlDark;
            this.prgAppSettings.Location = new System.Drawing.Point(1, 1);
            this.prgAppSettings.Name = "prgAppSettings";
            this.prgAppSettings.Size = new System.Drawing.Size(341, 287);
            this.prgAppSettings.TabIndex = 0;
            // 
            // FrmPropertyGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 288);
            this.Controls.Add(this.prgAppSettings);
            this.Name = "FrmPropertyGrid";
            this.Text = "Estudo Property Grid";
            this.Load += new System.EventHandler(this.FrmPropertyGrid_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid prgAppSettings;
    }
}

