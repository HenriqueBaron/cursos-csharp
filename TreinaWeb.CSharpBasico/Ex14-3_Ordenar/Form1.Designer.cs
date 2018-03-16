namespace Ex14_3_Ordenar
{
    partial class FrmOrdenarLista
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
            this.lsbDesordenados = new System.Windows.Forms.ListBox();
            this.txbValorEntrada = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lsbOrdenados = new System.Windows.Forms.ListBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbDesordenados
            // 
            this.lsbDesordenados.FormattingEnabled = true;
            this.lsbDesordenados.ItemHeight = 16;
            this.lsbDesordenados.Location = new System.Drawing.Point(118, 12);
            this.lsbDesordenados.Name = "lsbDesordenados";
            this.lsbDesordenados.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbDesordenados.Size = new System.Drawing.Size(100, 164);
            this.lsbDesordenados.TabIndex = 0;
            this.lsbDesordenados.TabStop = false;
            // 
            // txbValorEntrada
            // 
            this.txbValorEntrada.Location = new System.Drawing.Point(12, 12);
            this.txbValorEntrada.Name = "txbValorEntrada";
            this.txbValorEntrada.Size = new System.Drawing.Size(100, 22);
            this.txbValorEntrada.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 40);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 65);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar item à lista";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lsbOrdenados
            // 
            this.lsbOrdenados.FormattingEnabled = true;
            this.lsbOrdenados.ItemHeight = 16;
            this.lsbOrdenados.Location = new System.Drawing.Point(224, 12);
            this.lsbOrdenados.Name = "lsbOrdenados";
            this.lsbOrdenados.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbOrdenados.Size = new System.Drawing.Size(100, 164);
            this.lsbOrdenados.TabIndex = 0;
            this.lsbOrdenados.TabStop = false;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(12, 111);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 65);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // FrmOrdenarLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 192);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbValorEntrada);
            this.Controls.Add(this.lsbOrdenados);
            this.Controls.Add(this.lsbDesordenados);
            this.Name = "FrmOrdenarLista";
            this.Text = "Ordenador de Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbDesordenados;
        private System.Windows.Forms.TextBox txbValorEntrada;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lsbOrdenados;
        private System.Windows.Forms.Button btnOrdenar;
    }
}

