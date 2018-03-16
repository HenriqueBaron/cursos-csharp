using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoSwitch
{
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void btnVerificarNumero_Click(object sender, EventArgs e)
        {
            int numeroDigitado = Convert.ToInt32(txbNumero.Text);
            //0 ~ 3: Número baixo
            //4 ~ 6: Número médio
            //7 p/ cima: Número alto
            /*if ((numeroDigitado >= 0) && (numeroDigitado <= 3)) {
                MessageBox.Show("Número baixo");
            } else if ((numeroDigitado >= 4) && (numeroDigitado <= 6)) {
                MessageBox.Show("Número médio");
            } else
            {
                MessageBox.Show("Número alto");
            }*/
            switch (numeroDigitado)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    MessageBox.Show("Número baixo");
                    break;
                case 4:
                case 5:
                case 6:
                    MessageBox.Show("Número médio");
                    break;
                default:
                    MessageBox.Show("Número alto");
                    break;
            }
        }
    }
}
