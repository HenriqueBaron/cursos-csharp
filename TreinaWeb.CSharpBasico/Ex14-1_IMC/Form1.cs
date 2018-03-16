using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex14_1_IMC
{
    public partial class frmCalculoIMC : Form
    {
        public frmCalculoIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txbPeso.Text);
            double altura = Convert.ToDouble(txbAltura.Text);
            double resultado = peso / Math.Pow(altura, 2);
            txbResultado.Text = resultado.ToString();
        }
    }
}
