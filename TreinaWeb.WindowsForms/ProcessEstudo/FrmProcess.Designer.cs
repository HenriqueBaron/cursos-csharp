namespace ProcessEstudo
{
    partial class FrmProcess
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
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.lblProcesso = new System.Windows.Forms.Label();
            this.lblIniciado = new System.Windows.Forms.Label();
            this.lblFinalizado = new System.Windows.Forms.Label();
            this.lblMemoriaFisica = new System.Windows.Forms.Label();
            this.lblMemoriaVirtual = new System.Windows.Forms.Label();
            this.lblProcessador = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Location = new System.Drawing.Point(126, 12);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(150, 23);
            this.btnIniciarParar.TabIndex = 0;
            this.btnIniciarParar.Text = "Iniciar/Parar Processo";
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Location = new System.Drawing.Point(12, 60);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(57, 13);
            this.lblProcesso.TabIndex = 1;
            this.lblProcesso.Text = "Processo: ";
            // 
            // lblIniciado
            // 
            this.lblIniciado.AutoSize = true;
            this.lblIniciado.Location = new System.Drawing.Point(12, 85);
            this.lblIniciado.Name = "lblIniciado";
            this.lblIniciado.Size = new System.Drawing.Size(47, 13);
            this.lblIniciado.TabIndex = 2;
            this.lblIniciado.Text = "Iniciado:";
            // 
            // lblFinalizado
            // 
            this.lblFinalizado.AutoSize = true;
            this.lblFinalizado.Location = new System.Drawing.Point(12, 110);
            this.lblFinalizado.Name = "lblFinalizado";
            this.lblFinalizado.Size = new System.Drawing.Size(60, 13);
            this.lblFinalizado.TabIndex = 3;
            this.lblFinalizado.Text = "Finalizado: ";
            // 
            // lblMemoriaFisica
            // 
            this.lblMemoriaFisica.AutoSize = true;
            this.lblMemoriaFisica.Location = new System.Drawing.Point(12, 135);
            this.lblMemoriaFisica.Name = "lblMemoriaFisica";
            this.lblMemoriaFisica.Size = new System.Drawing.Size(82, 13);
            this.lblMemoriaFisica.TabIndex = 4;
            this.lblMemoriaFisica.Text = "Memória Física:";
            // 
            // lblMemoriaVirtual
            // 
            this.lblMemoriaVirtual.AutoSize = true;
            this.lblMemoriaVirtual.Location = new System.Drawing.Point(12, 160);
            this.lblMemoriaVirtual.Name = "lblMemoriaVirtual";
            this.lblMemoriaVirtual.Size = new System.Drawing.Size(82, 13);
            this.lblMemoriaVirtual.TabIndex = 5;
            this.lblMemoriaVirtual.Text = "Memória Virtual:";
            // 
            // lblProcessador
            // 
            this.lblProcessador.AutoSize = true;
            this.lblProcessador.Location = new System.Drawing.Point(12, 185);
            this.lblProcessador.Name = "lblProcessador";
            this.lblProcessador.Size = new System.Drawing.Size(66, 13);
            this.lblProcessador.TabIndex = 6;
            this.lblProcessador.Text = "Processador";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // FrmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 213);
            this.Controls.Add(this.lblProcessador);
            this.Controls.Add(this.lblMemoriaVirtual);
            this.Controls.Add(this.lblMemoriaFisica);
            this.Controls.Add(this.lblFinalizado);
            this.Controls.Add(this.lblIniciado);
            this.Controls.Add(this.lblProcesso);
            this.Controls.Add(this.btnIniciarParar);
            this.Name = "FrmProcess";
            this.Text = "Process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.Label lblProcesso;
        private System.Windows.Forms.Label lblIniciado;
        private System.Windows.Forms.Label lblFinalizado;
        private System.Windows.Forms.Label lblMemoriaFisica;
        private System.Windows.Forms.Label lblMemoriaVirtual;
        private System.Windows.Forms.Label lblProcessador;
        private System.Diagnostics.Process process1;
    }
}

