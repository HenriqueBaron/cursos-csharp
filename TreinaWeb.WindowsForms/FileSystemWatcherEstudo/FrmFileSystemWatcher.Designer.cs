namespace FileSystemWatcherEstudo
{
    partial class FrmFileSystemWatcher
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
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnMonitorar = new System.Windows.Forms.Button();
            this.fswMonitor = new System.IO.FileSystemWatcher();
            this.lstEventos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fswMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(64, 6);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(397, 20);
            this.txtCaminho.TabIndex = 1;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(467, 4);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnMonitorar
            // 
            this.btnMonitorar.Location = new System.Drawing.Point(233, 32);
            this.btnMonitorar.Name = "btnMonitorar";
            this.btnMonitorar.Size = new System.Drawing.Size(75, 23);
            this.btnMonitorar.TabIndex = 3;
            this.btnMonitorar.Text = "Monitorar";
            this.btnMonitorar.UseVisualStyleBackColor = true;
            this.btnMonitorar.Click += new System.EventHandler(this.btnMonitorar_Click);
            // 
            // fswMonitor
            // 
            this.fswMonitor.EnableRaisingEvents = true;
            this.fswMonitor.SynchronizingObject = this;
            this.fswMonitor.Changed += new System.IO.FileSystemEventHandler(this.fswMonitor_Changed);
            this.fswMonitor.Created += new System.IO.FileSystemEventHandler(this.fswMonitor_Created);
            this.fswMonitor.Deleted += new System.IO.FileSystemEventHandler(this.fswMonitor_Deleted);
            this.fswMonitor.Renamed += new System.IO.RenamedEventHandler(this.fswMonitor_Renamed);
            // 
            // lstEventos
            // 
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.Location = new System.Drawing.Point(12, 61);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(530, 251);
            this.lstEventos.TabIndex = 4;
            // 
            // FrmFileSystemWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 328);
            this.Controls.Add(this.lstEventos);
            this.Controls.Add(this.btnMonitorar);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label1);
            this.Name = "FrmFileSystemWatcher";
            this.Text = "File System Watcher";
            ((System.ComponentModel.ISupportInitialize)(this.fswMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnMonitorar;
        private System.IO.FileSystemWatcher fswMonitor;
        private System.Windows.Forms.ListBox lstEventos;
    }
}

