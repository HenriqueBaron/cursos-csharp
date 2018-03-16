using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritmeticos
{
    public partial class frmCalculadora : Form
    {

        int numero1;
        int numero2;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            //int resultado = numero1 + numero2;
            //numero1 += numero2;
            txbResultado.Text = Somar(numero1, numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            //int resultado = numero1 - numero2;
            //numero1 -= numero2;
            txbResultado.Text = Subtrair(numero1, numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            //int resultado = numero1 * numero2;
            //numero1 *= numero2;
            txbResultado.Text = Multiplicar(numero1, numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbNumero1.Text);
            numero2 = Convert.ToInt32(txbNumero2.Text);
            //int resultado = numero1 / numero2;
            //numero1 /= numero2;
            txbResultado.Text = Dividir(numero1, numero2).ToString();
        }

        int Somar(params int[] numeros)
        {
            int resultado = 0;
            foreach (int numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        int Subtrair(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        int Multiplicar(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        int Dividir(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }
    }
}
