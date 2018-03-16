using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_2_ImpostoTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a área total do terreno: ");
            double areaTotal = double.Parse(Console.ReadLine());
            Console.Write("Entre com a área construída do terreno: ");
            double areaConstruida = double.Parse(Console.ReadLine());

            double areaNaoConstruida = areaTotal - areaConstruida;
            double impostoConstruido = areaConstruida * 5;
            double impostoNaoConstruido = areaNaoConstruida * 3.8;
            Console.WriteLine("O valor total de imposto pelo terreno é de {0}", (impostoConstruido + impostoNaoConstruido).ToString("C"));
            Console.ReadKey();
        }
    }
}
