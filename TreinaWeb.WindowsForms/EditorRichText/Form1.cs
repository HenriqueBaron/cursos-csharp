using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorRichText
{
    public partial class frmEditorRT : Form
    {
        public frmEditorRT()
        {
            InitializeComponent();
        }

        private void frmEditorRT_Load(object sender, EventArgs e)
        {
            rtxTexto.ContextMenuStrip = cmsOpcoesTexto;
            lblStatus.Text = "";
        }

        private void btnFonte_Click(object sender, EventArgs e)
        {
            SelecionarFonte();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelecionarFonte();
        }

        private void SelecionarFonte()
        {
            FontDialog font = new FontDialog();
            font.FontMustExist = true;

            if (font.ShowDialog() == DialogResult.OK)
            {
                rtxTexto.SelectionFont = font.Font;
                rtxTexto.SelectionColor = font.Color;
                lblStatus.Text = "Fonte modificada para " + font.Font.Name;
            }
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            SelecionarCor();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelecionarCor();
        }

        private void SelecionarCor()
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = true;

            if (color.ShowDialog() == DialogResult.OK)
            {
                rtxTexto.SelectionColor = color.Color;
                lblStatus.ForeColor = color.Color;
                lblStatus.Text = "Cor modificada com sucesso.";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.CheckFileExists = false;
            save.DefaultExt = "rtf";
            save.Filter = "Rich Text Format|*.rtf";
            save.OverwritePrompt = true;
            save.InitialDirectory = @"C:\Users\Henrique Baron\Desktop";
            save.Title = "Salvar";

            if (save.ShowDialog() == DialogResult.OK)
            {
                rtxTexto.SaveFile(save.FileName);
                lblStatus.Text = "Arquivo salvo com sucesso.";
            }
        }
    }
}
