using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Os métodos de filtragem e agrupamento na sintaxe de método do LINQ
             * esperam um delegate. Por isso são utilizadas as expressões lambda. */
            var methodLambda = numeros.Where(n => n % 2 == 0);

            // Mas outras formas, como com um delegate, também são possíveis, como:
            // Utilizando um Function chamando um método
            Func<int, bool> func = new Func<int, bool>(MeuMetodo);
            var methodDelegate = numeros.Where(func);

            // Utilizando um Function com método anônimo
            Func<int, bool> funcAnon = delegate (int arg) { return arg % 2 == 0; };
            var methodAnon = numeros.Where(funcAnon);


            // Mas, se um tipo anônimo fosse utilizado:
            var developers = new[]
            {
                new {Name = "Paolo", Language = "C#"},
                new {Name = "Marco", Language = "C#"},
                new {Name = "Frank", Language = "VB.NET"}
            };

            /* Não seria possível criar um método que analise a propriedade Language desse tipo como a cláusula
             * Where() necessita, pois o tipo é anônimo. Dessa forma, apenas a expressão lambda atende. */
            var developersUsingCSharp = developers.Where(d => d.Language.Contains("C#")).Select(d => d.Name);

            ExibirResultado(methodLambda);
            ExibirResultado(methodDelegate);
            ExibirResultado(methodAnon);
            ExibirResultado(developersUsingCSharp);
            Console.ReadKey();
        }

        private static bool MeuMetodo(int arg)
        {
            return arg % 2 == 0;
        }

        private static void ExibirResultado(IEnumerable<int> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void ExibirResultado(IEnumerable<string> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

    }
}
