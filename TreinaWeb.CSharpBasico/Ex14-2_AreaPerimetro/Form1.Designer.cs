namespace Ex14_2_AreaPerimetro
{
    partial class FrmAreaPerimetro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbComprimento = new System.Windows.Forms.TextBox();
            this.TxbLargura = new System.Windows.Forms.TextBox();
            this.TxbArea = new System.Windows.Forms.TextBox();
            this.TxbPerimetro = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comprimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Área:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Perímetro:";
            // 
            // TxbComprimento
            // 
            this.TxbComprimento.Location = new System.Drawing.Point(113, 6);
            this.TxbComprimento.Name = "TxbComprimento";
            this.TxbComprimento.Size = new System.Drawing.Size(100, 22);
            this.TxbComprimento.TabIndex = 0;
            // 
            // TxbLargura
            // 
            this.TxbLargura.Location = new System.Drawing.Point(113, 36);
            this.TxbLargura.Name = "TxbLargura";
            this.TxbLargura.Size = new System.Drawing.Size(100, 22);
            this.TxbLargura.TabIndex = 1;
            // 
            // TxbArea
            // 
            this.TxbArea.Location = new System.Drawing.Point(113, 96);
            this.TxbArea.Name = "TxbArea";
            this.TxbArea.ReadOnly = true;
            this.TxbArea.Size = new System.Drawing.Size(100, 22);
            this.TxbArea.TabIndex = 2;
            this.TxbArea.TabStop = false;
            // 
            // TxbPerimetro
            // 
            this.TxbPerimetro.Location = new System.Drawing.Point(113, 124);
            this.TxbPerimetro.Name = "TxbPerimetro";
            this.TxbPerimetro.ReadOnly = true;
            this.TxbPerimetro.Size = new System.Drawing.Size(100, 22);
            this.TxbPerimetro.TabIndex = 3;
            this.TxbPerimetro.TabStop = false;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(231, 6);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(124, 52);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // FrmAreaPerimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 158);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxbPerimetro);
            this.Controls.Add(this.TxbArea);
            this.Controls.Add(this.TxbLargura);
            this.Controls.Add(this.TxbComprimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAreaPerimetro";
            this.Text = "Propriedades do Retângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbComprimento;
        private System.Windows.Forms.TextBox TxbLargura;
        private System.Windows.Forms.TextBox TxbArea;
        private System.Windows.Forms.TextBox TxbPerimetro;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

