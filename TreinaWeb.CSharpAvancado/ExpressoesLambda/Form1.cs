using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpressoesLambda
{
    public partial class FrmLambda : Form
    {
        public FrmLambda()
        {
            InitializeComponent();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            /* Método tradicional, declarando o delegate e atribuindo a ele um método.
             * Percebe-se que este método só existe nesta classe e supõe-se que seja chamado apenas aqui.
             * Para evitar a digitação excessiva de código, evita-se esta alternativa e atribui-se ao
             * delegate uma expressão lambda, como exibido abaixo deste delegate "tradicional", comentado.
             */
            //Func<string, string, string> concatenador = Concatenar;

            Func<string, string, string> concatenador = (s1, s2) => { return s1 + " " + s2; };

            Action<string> escritor = (s1) =>
            {
                txbResultado.Text = s1;
            };

            escritor(concatenador(txbTexto1.Text, txbTexto2.Text));
        }

        private string Concatenar(string s1, string s2)
        {
            return s1 + " " + s2;
        }
    }
}
