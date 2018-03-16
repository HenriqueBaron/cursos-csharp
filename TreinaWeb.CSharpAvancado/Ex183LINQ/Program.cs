using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex183LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valoresA = new List<int>() { 0, 1, 2, 3, 4 };
            List<int> valoresB = new List<int>() { 0, 2, 4, 6 };

            IEnumerable<int> numerosComuns = valoresA.Where(v => valoresB.Exists(e => e == v));

            foreach (int valor in numerosComuns)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("");

            IEnumerable<int> numerosExclusivos = valoresA.Where(v => !valoresB.Exists(e => e == v));

            foreach (int valor in numerosExclusivos)
            {
                Console.WriteLine(valor);
            }
            Console.ReadKey();
        }
    }
}
