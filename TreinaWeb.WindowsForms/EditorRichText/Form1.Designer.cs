namespace EditorRichText
{
    partial class frmEditorRT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorRT));
            this.tstFerramentas = new System.Windows.Forms.ToolStrip();
            this.btnFonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.rtxTexto = new System.Windows.Forms.RichTextBox();
            this.cmsOpcoesTexto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sstStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstFerramentas.SuspendLayout();
            this.cmsOpcoesTexto.SuspendLayout();
            this.sstStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstFerramentas
            // 
            this.tstFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFonte,
            this.toolStripSeparator1,
            this.btnCor,
            this.toolStripSeparator2,
            this.btnSalvar});
            this.tstFerramentas.Location = new System.Drawing.Point(0, 0);
            this.tstFerramentas.Name = "tstFerramentas";
            this.tstFerramentas.Size = new System.Drawing.Size(427, 25);
            this.tstFerramentas.TabIndex = 0;
            this.tstFerramentas.Text = "toolStrip1";
            // 
            // btnFonte
            // 
            this.btnFonte.Image = ((System.Drawing.Image)(resources.GetObject("btnFonte.Image")));
            this.btnFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(57, 22);
            this.btnFonte.Text = "Fonte";
            this.btnFonte.Click += new System.EventHandler(this.btnFonte_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCor
            // 
            this.btnCor.Image = ((System.Drawing.Image)(resources.GetObject("btnCor.Image")));
            this.btnCor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(46, 22);
            this.btnCor.Text = "Cor";
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(58, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rtxTexto
            // 
            this.rtxTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxTexto.Location = new System.Drawing.Point(0, 25);
            this.rtxTexto.Name = "rtxTexto";
            this.rtxTexto.Size = new System.Drawing.Size(427, 315);
            this.rtxTexto.TabIndex = 1;
            this.rtxTexto.Text = "";
            // 
            // cmsOpcoesTexto
            // 
            this.cmsOpcoesTexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.corToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.cmsOpcoesTexto.Name = "cmsOpcoesTexto";
            this.cmsOpcoesTexto.Size = new System.Drawing.Size(153, 92);
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fonteToolStripMenuItem.Text = "Fonte";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // corToolStripMenuItem
            // 
            this.corToolStripMenuItem.Name = "corToolStripMenuItem";
            this.corToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.corToolStripMenuItem.Text = "Cor";
            this.corToolStripMenuItem.Click += new System.EventHandler(this.corToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // sstStatus
            // 
            this.sstStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.sstStatus.Location = new System.Drawing.Point(0, 318);
            this.sstStatus.Name = "sstStatus";
            this.sstStatus.Size = new System.Drawing.Size(427, 22);
            this.sstStatus.TabIndex = 3;
            this.sstStatus.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // frmEditorRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 340);
            this.Controls.Add(this.sstStatus);
            this.Controls.Add(this.rtxTexto);
            this.Controls.Add(this.tstFerramentas);
            this.Name = "frmEditorRT";
            this.Text = "Editor Rich Text";
            this.Load += new System.EventHandler(this.frmEditorRT_Load);
            this.tstFerramentas.ResumeLayout(false);
            this.tstFerramentas.PerformLayout();
            this.cmsOpcoesTexto.ResumeLayout(false);
            this.sstStatus.ResumeLayout(false);
            this.sstStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstFerramentas;
        private System.Windows.Forms.ToolStripButton btnFonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.RichTextBox rtxTexto;
        private System.Windows.Forms.ContextMenuStrip cmsOpcoesTexto;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip sstStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

