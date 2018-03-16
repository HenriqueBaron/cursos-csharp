using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animacoes
{
    public partial class FrmAnimacao : Form
    {
        int count = 0;

        public FrmAnimacao()
        {
            InitializeComponent();
        }

        private void FrmAnimacao_Load(object sender, EventArgs e)
        {
            pbxAnimacao.BackgroundImageLayout = ImageLayout.Center;
            pbxAnimacao.BackgroundImage = Properties.Resources._04;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            switch (count)
            {
                case 1:
                    pbxAnimacao.BackgroundImage = Properties.Resources._01;
                    pbxAnimacao.Location = new Point(32, 12);
                    break;

                case 2:
                    pbxAnimacao.BackgroundImage = Properties.Resources._02;
                    pbxAnimacao.Location = new Point(52, 12);
                    break;

                case 3:
                    pbxAnimacao.BackgroundImage = Properties.Resources._03;
                    pbxAnimacao.Location = new Point(72, 12);
                    break;

                default:
                    pbxAnimacao.BackgroundImage = Properties.Resources._04;
                    pbxAnimacao.Location = new Point(32, 12);
                    count = 0;
                    break;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
