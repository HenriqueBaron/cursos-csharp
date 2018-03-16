using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Sintaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // No LINQ é possível utilizar duas sintaxes para realizar as consultas
            // A Query Syntax:
            var query = from n in numeros
                        where (n % 2) == 0
                        select n;

            // e a Method Syntax:
            var method = numeros.Where(n => n % 2 == 0);

            // O CLR acaba sempre convertendo a sintaxe de consulta para a sintaxe de método ao executar.

            Console.WriteLine("Filtro - sintaxe de consulta");
            ExibeResultado(query);

            Console.WriteLine("Filtro - sintaxe de método");
            ExibeResultado(method);

            // Um outro exemplo, agora também utilizando ordenação
            var orderQuery = from n in numeros
                             where (n % 2) == 0
                             orderby n descending
                             select n;

            var orderMethod = numeros.Where(n => n % 2 == 0).OrderByDescending(n => n);

            Console.WriteLine();
            Console.WriteLine("Filtro e ordenação - sintaxe de consulta");
            ExibeResultado(orderQuery);
            Console.WriteLine("Filtro e ordenação - sintaxe de método");
            ExibeResultado(orderMethod);
            Console.ReadKey();
        }

        private static void ExibeResultado(IEnumerable<int> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
