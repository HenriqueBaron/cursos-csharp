using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_1.MetodoGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> valores = new List<double> { 0, 1, 2, 3, 4, 5 };
            Console.WriteLine("Valores maiores que o limite: {0}", ObterMaiores<double>(valores, 2));
            Console.ReadKey();
        }

        private static int ObterMaiores<T>(List<T> valores, T limiteMinimo)
        {
            int resultado = 0;
            foreach (T item in valores)
            {
                if (Convert.ToDouble(item) > Convert.ToDouble(limiteMinimo))
                {
                    resultado++;
                }
            }
            return resultado;
        }
    }
}
