using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Associacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Obter a fonte de dados. Neste caso, são duas (dois Dictionary)
            Dictionary<int, string> clientes = new Dictionary<int, string>();
            clientes.Add(1, "Thiago");
            clientes.Add(2, "Pedro");
            clientes.Add(3, "Maria");
            clientes.Add(4, "José");
            clientes.Add(5, "Diego");

            // O método Guid.NewGuid() simplesmente uma GUID, que é uma chave única.
            /* Entre estes dois Dictionary, o Value dos pedidos funciona como se fosse uma coluna
             * de uma tabela de banco de dados que contém uma foreign key para a tabela de clientes */
            Dictionary<string, int> pedidos = new Dictionary<string, int>();
            pedidos.Add(Guid.NewGuid().ToString(), 1);
            pedidos.Add(Guid.NewGuid().ToString(), 5);
            pedidos.Add(Guid.NewGuid().ToString(), 5);
            pedidos.Add(Guid.NewGuid().ToString(), 3);
            pedidos.Add(Guid.NewGuid().ToString(), 2);
            pedidos.Add(Guid.NewGuid().ToString(), 1);
            pedidos.Add(Guid.NewGuid().ToString(), 2);
            pedidos.Add(Guid.NewGuid().ToString(), 4);
            pedidos.Add(Guid.NewGuid().ToString(), 4);

            // 2. Prepara a consulta, com uma associação, utilizando a cláusula JOIN
            var result = from c in clientes
                         join p in pedidos on c.Key equals p.Value
                         select new
                         {
                             Cliente = c.Value,
                             Pedido = p.Key
                         };

            // 3. Executa a consulta e retorna os resultados
            foreach (var item in result)
            {
                Console.WriteLine("Cliente {0} \t- Pedido {1}", item.Cliente, item.Pedido);
            }

            Console.ReadKey();
        }
    }
}
