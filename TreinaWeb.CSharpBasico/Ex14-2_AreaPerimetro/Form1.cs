using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex14_2_AreaPerimetro
{
    public partial class FrmAreaPerimetro : Form
    {
        public FrmAreaPerimetro()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double comprimento = Convert.ToDouble(TxbComprimento.Text);
            double largura = Convert.ToDouble(TxbLargura.Text);
            double area = comprimento * largura;
            double perimetro = 2 * comprimento + 2 * largura;

            TxbArea.Text = area.ToString();
            TxbPerimetro.Text = perimetro.ToString();
        }
    }
}
