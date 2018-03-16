using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_2.DelegateComGenerics
{
    class Program
    {
        //Um delegate para executar um método qualquer que recebe como parâmetro um tipo qualquer
        private delegate void DelegateTeste<T>(T valor);

        static void Main(string[] args)
        {
            DelegateTeste<double> metodoDelegado = new DelegateTeste<double>(IncrementarValor);
            string[] conjuntoTextos = { "1", "2", "3", "4" };
            double[] conjuntoValores = { 1, 2, 3, 4 };
            MetodoTeste<double>(metodoDelegado, conjuntoValores);
            Console.ReadKey();
        }

        //Método que aplica em cada item de um array de um tipo qualquer o método chamado através de um delegate
        private static void MetodoTeste<T>(DelegateTeste<T> d, T[] conjuntoValores)
        {
            foreach (T item in conjuntoValores)
            {
                d(item);
            }
        }

        //Os dois métodos abaixo têm uma assinatura compatível com o delegate, portanto podem ser chamados com ele.
        private static void ExibirValor<T>(T valor)
        {
            Console.WriteLine(valor.ToString());
        }

        private static void IncrementarValor<T>(T valor)
        {
            double valorEmNumero = Convert.ToDouble(valor);
            valorEmNumero++;
            Console.WriteLine(valorEmNumero);
        }
    }
}
