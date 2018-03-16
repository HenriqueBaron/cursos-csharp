using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CarregarImagem();
            }
        }

        private void CarregarImagem()
        {
            Bitmap imagem = Bitmap.FromFile(openFileDialog1.FileName) as Bitmap;
            pbxImagens.Image = imagem;
            pbxImagens.SizeMode = PictureBoxSizeMode.Normal;

            if (imagem.Height > pbxImagens.Height)
            {
                vScrollBar1.Enabled = true;
                vScrollBar1.Maximum = imagem.Height;
            }
            else vScrollBar1.Enabled = false;

            if (imagem.Width > pbxImagens.Width)
            {
                hScrollBar1.Enabled = true;
                hScrollBar1.Maximum = imagem.Width;
            }
            else hScrollBar1.Enabled = false;
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtLargura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAltura.Text)
                && !string.IsNullOrEmpty(txtLargura.Text)
                && !string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                int largura = Convert.ToInt32(txtLargura.Text);
                int altura = Convert.ToInt32(txtAltura.Text);
                pbxImagens.Image = RedimensionarImagem(new Bitmap(openFileDialog1.FileName), largura, altura);
            }
        }

        private Image RedimensionarImagem(Bitmap imagem, int largura, int altura)
        {
            Bitmap resultado = new Bitmap(largura, altura);
            using (Graphics grafico = Graphics.FromImage(resultado))
            {
                grafico.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                grafico.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                grafico.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                grafico.DrawImage(imagem, 0, 0, altura, largura);
            }
            return resultado;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Bitmap imagem = new Bitmap(pbxImagens.Image);
                    imagem.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            RolarImagem(e.NewValue, vScrollBar1.Value);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            RolarImagem(hScrollBar1.Value, e.NewValue);
        }

        private void RolarImagem(int posX, int posY)
        {
            Graphics graphic = pbxImagens.CreateGraphics();

            int xWidth = pbxImagens.Width;
            int yHeight = pbxImagens.Height;
            graphic.DrawImage(pbxImagens.Image,
                new Rectangle(0, 0, xWidth, yHeight),
                new Rectangle(posX, posY, xWidth, yHeight),
                GraphicsUnit.Pixel);
            pbxImagens.Update();
        }
    }
}
