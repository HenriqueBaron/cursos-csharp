namespace Controles
{
    partial class frmListViewImageList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListViewImageList));
            this.lvwInfoDiretorio = new System.Windows.Forms.ListView();
            this.cmsExibicao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.íconesGrandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.íconesPequenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imlListaImagens1 = new System.Windows.Forms.ImageList(this.components);
            this.imlListaImagens2 = new System.Windows.Forms.ImageList(this.components);
            this.cmsExibicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwInfoDiretorio
            // 
            this.lvwInfoDiretorio.ContextMenuStrip = this.cmsExibicao;
            this.lvwInfoDiretorio.LargeImageList = this.imlListaImagens2;
            this.lvwInfoDiretorio.Location = new System.Drawing.Point(12, 12);
            this.lvwInfoDiretorio.Name = "lvwInfoDiretorio";
            this.lvwInfoDiretorio.Size = new System.Drawing.Size(585, 452);
            this.lvwInfoDiretorio.SmallImageList = this.imlListaImagens1;
            this.lvwInfoDiretorio.TabIndex = 1;
            this.lvwInfoDiretorio.UseCompatibleStateImageBehavior = false;
            this.lvwInfoDiretorio.DoubleClick += new System.EventHandler(this.lvwInfoDiretorio_DoubleClick);
            // 
            // cmsExibicao
            // 
            this.cmsExibicao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.cmsExibicao.Name = "cmsExibicao";
            this.cmsExibicao.Size = new System.Drawing.Size(103, 26);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.íconesGrandesToolStripMenuItem,
            this.íconesPequenosToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // íconesGrandesToolStripMenuItem
            // 
            this.íconesGrandesToolStripMenuItem.Name = "íconesGrandesToolStripMenuItem";
            this.íconesGrandesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.íconesGrandesToolStripMenuItem.Text = "Ícones Grandes";
            this.íconesGrandesToolStripMenuItem.Click += new System.EventHandler(this.íconesGrandesToolStripMenuItem_Click);
            // 
            // íconesPequenosToolStripMenuItem
            // 
            this.íconesPequenosToolStripMenuItem.Name = "íconesPequenosToolStripMenuItem";
            this.íconesPequenosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.íconesPequenosToolStripMenuItem.Text = "Ícones Pequenos";
            this.íconesPequenosToolStripMenuItem.Click += new System.EventHandler(this.íconesPequenosToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // imlListaImagens1
            // 
            this.imlListaImagens1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlListaImagens1.ImageStream")));
            this.imlListaImagens1.TransparentColor = System.Drawing.Color.Transparent;
            this.imlListaImagens1.Images.SetKeyName(0, "Folder128.png");
            this.imlListaImagens1.Images.SetKeyName(1, "File128.png");
            // 
            // imlListaImagens2
            // 
            this.imlListaImagens2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlListaImagens2.ImageStream")));
            this.imlListaImagens2.TransparentColor = System.Drawing.Color.Transparent;
            this.imlListaImagens2.Images.SetKeyName(0, "Folder128.png");
            this.imlListaImagens2.Images.SetKeyName(1, "File128.png");
            // 
            // frmListViewImageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 476);
            this.Controls.Add(this.lvwInfoDiretorio);
            this.Name = "frmListViewImageList";
            this.Text = "frmListViewImageList";
            this.Load += new System.EventHandler(this.frmListViewImageList_Load);
            this.cmsExibicao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwInfoDiretorio;
        private System.Windows.Forms.ContextMenuStrip cmsExibicao;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem íconesGrandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem íconesPequenosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ImageList imlListaImagens1;
        private System.Windows.Forms.ImageList imlListaImagens2;
    }
}