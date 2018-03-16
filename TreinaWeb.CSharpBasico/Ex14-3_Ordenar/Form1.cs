using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex14_3_Ordenar
{
    public partial class FrmOrdenarLista : Form
    {
        public FrmOrdenarLista()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = Int32.Parse(txbValorEntrada.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("O valor informado não é um número. Favor informar apenas números inteiros.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            lsbDesordenados.Items.Add(txbValorEntrada.Text);
            txbValorEntrada.Clear();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            String[] itensDesordenados = new String[lsbDesordenados.Items.Count];
            int[] valoresDesordenados = new int[lsbDesordenados.Items.Count];
            int[] valoresOrdenados = new int[lsbDesordenados.Items.Count];
            lsbDesordenados.Items.CopyTo(itensDesordenados, 0);
            lsbOrdenados.Items.Clear();

            //Converte o array desordenado de strings para inteiros
            for (int i = 0; i < itensDesordenados.Length; i++)
            {
                valoresDesordenados[i] = Int32.Parse(itensDesordenados[i]);
            }

            //Executa a mesma função que foi criada manualmente, utilizano um recurso pronto da classe Array do .NET Framework
            //valoresOrdenados = valoresDesordenados;
            //Array.Sort(valoresOrdenados);

            //Para cada elemento do array de itens ordenados, procura o menor número disponível no array de
            //itens desordenados
            for (int i = 0; i < valoresOrdenados.Length - 1; i++)
            {
                int indice = 0;
                for (int j = 1; j < valoresDesordenados.Length; j++)
                {
                    if (valoresDesordenados[j] < valoresDesordenados[indice]) indice = j;
                }
                valoresOrdenados[i] = valoresDesordenados[indice];
                valoresDesordenados = RemoverElemento(valoresDesordenados, indice);
            }
            valoresOrdenados[valoresOrdenados.Length - 1] = valoresDesordenados[0];
            
            foreach (int valor in valoresOrdenados)
            {
                lsbOrdenados.Items.Add(valor);
            }
        }

        private int[] RemoverElemento(int[] valores, int indice)
        {
            //Cria um novo array com um elemento a menos em tamanho
            int[] resultado = new int[valores.Length - 1];

            //Copia o array de entrada até o índice que antecede o elemento a ser removido
            for (int i = 0; i < indice; i++)
            {
                resultado[i] = valores[i];
            }

            //Se o elemento a ser removido não for o último, desloca todos os elementos posteriores para uma posição
            //a menos.
            if (indice < valores.Length - 1)
            {
                for (int i = indice; i < valores.Length - 1; i++)
                {
                    resultado[i] = valores[i + 1];
                }
            }
            return resultado;
        }

    }
}
