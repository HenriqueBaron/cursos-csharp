using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uma consulta LINQ é executada em três passos:

            // 1. Obter a fonte de dados
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 2. Criar a consulta
            // Nota: apesar de ter sido empregada inferência de tipo (var), query é um IEnumerable<T>.
            var query = from num in numeros
                        where ((num % 2) == 0 && num < 10) || num == 1
                        orderby num descending
                        select num;

            // 3. Executar a consulta, obtendo o resultado
            foreach (int item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
