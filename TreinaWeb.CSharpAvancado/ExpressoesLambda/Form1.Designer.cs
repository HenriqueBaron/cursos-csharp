namespace ExpressoesLambda
{
    partial class FrmLambda
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
            this.txbTexto1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTexto2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbTexto1
            // 
            this.txbTexto1.Location = new System.Drawing.Point(73, 9);
            this.txbTexto1.Name = "txbTexto1";
            this.txbTexto1.Size = new System.Drawing.Size(385, 20);
            this.txbTexto1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto 1:";
            // 
            // txbTexto2
            // 
            this.txbTexto2.Location = new System.Drawing.Point(73, 35);
            this.txbTexto2.Name = "txbTexto2";
            this.txbTexto2.Size = new System.Drawing.Size(385, 20);
            this.txbTexto2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto 2:";
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(73, 61);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(75, 23);
            this.btnConcatenar.TabIndex = 2;
            this.btnConcatenar.Text = "Concatenar";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(73, 90);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(385, 20);
            this.txbResultado.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resultado: ";
            // 
            // FrmLambda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 121);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txbTexto2);
            this.Controls.Add(this.txbTexto1);
            this.Name = "FrmLambda";
            this.Text = "Estudo sobre Lambdas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTexto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTexto2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Label label3;
    }
}

