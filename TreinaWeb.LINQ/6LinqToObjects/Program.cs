using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este projeto demonstra o uso do LINQ em coleções de objetos.

            // 1. Obtém a fonte de dados.
            List<Cliente> clientes = CriarClientes();
            List<Pedido> pedidos = CriarPedidos();
            IEnumerable<Cliente> resultado;

            // 2. Cria a consulta - exemplo de ordenação
            resultado = from c in clientes
                        orderby c.Nome descending
                        select c;
            // Em sintaxe de método:
            //resultado = clientes.OrderByDescending(c => c.Nome);

            // 3. Obtém o resultado
            Console.WriteLine("Ordenação:");
            ExibirResultado(resultado.ToList());


            // 2. Cria outra consulta - exemplo de filtragem
            resultado = from c in clientes
                        where c.Email.Contains("treinaweb")
                        select c;
            // Em sintaxe de método:
            //resultado = clientes.Where(c => c.Email.Contains("treinaweb"));

            // 3. Exibe o resultado
            Console.WriteLine("Filtro:");
            ExibirResultado(resultado.ToList());


            // 2. Cria outra consulta - exemplo de agregação
            var resultadoAssoc = from c in clientes
                                 join p in pedidos
                                 on c.Id equals p.IdCliente
                                 into ClientesComPedidos
                                 select new
                                 {
                                     c.Nome,
                                     TotalDePedidos = ClientesComPedidos.Count()
                                 };
            // Em sintaxe de método
            //var resultadoAssoc = clientes.Join(pedidos, c => c.Id, p => p.IdCliente, (cliente, pedido) => new { cliente, pedido })
            //                        .GroupBy(a => a.cliente.Nome).Select(g => new { Nome = g.Key, TotalDePedidos = g.Count() });

            // 3. Exibe o resultado
            foreach (var item in resultadoAssoc)
            {
                Console.WriteLine("************************************");
                Console.WriteLine(item);
                Console.WriteLine("************************************");
            }

            Console.ReadKey();
        }

        private static List<Cliente> CriarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(
                new Cliente()
                {
                    Id = 1,
                    Nome = "Felipe Mourato",
                    Sexo = Cliente.SexoEnum.Masculino,
                    Nascimento = new DateTime(1980, 12, 1),
                    Email = "felipe@contoso.com"
                }
                );

            clientes.Add(
                new Cliente()
                {
                    Id = 2,
                    Nome = "Mauro Maurício",
                    Sexo = Cliente.SexoEnum.Masculino,
                    Nascimento = new DateTime(1970, 6, 12),
                    Email = "mauro@treinaweb.com.br"
                });

            clientes.Add(
                new Cliente()
                {
                    Id = 3,
                    Nome = "Suzan Suzi",
                    Sexo = Cliente.SexoEnum.Feminino,
                    Nascimento = new DateTime(1992, 2, 25),
                    Email = "suzan@treinaweb.com.br"
                });

            clientes.Add(
                new Cliente()
                {
                    Id = 4,
                    Nome = "Claudia Rodrigues",
                    Sexo = Cliente.SexoEnum.Feminino,
                    Nascimento = new DateTime(1990, 4, 13),
                    Email = "claudia@treinaweb.com.br"
                });

            return clientes;
        }

        static List<Pedido> CriarPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            pedidos.Add(
                new Pedido()
                {
                    Id = 1,
                    IdCliente = 1,
                    Data = DateTime.Now,
                    Preco = 40
                });

            pedidos.Add(
                new Pedido()
                {
                    Id = 2,
                    IdCliente = 1,
                    Data = DateTime.Now,
                    Preco = 100
                });

            pedidos.Add(
                new Pedido()
                {
                    Id = 3,
                    IdCliente = 2,
                    Data = DateTime.Now,
                    Preco = 450
                });

            pedidos.Add(
                new Pedido()
                {
                    Id = 4,
                    IdCliente = 3,
                    Data = DateTime.Now,
                    Preco = 32.1
                });

            pedidos.Add(
                new Pedido()
                {
                    Id = 5,
                    IdCliente = 3,
                    Data = DateTime.Now,
                    Preco = 343.52
                });

            pedidos.Add(
                new Pedido()
                {
                    Id = 6,
                    IdCliente = 4,
                    Data = DateTime.Now,
                    Preco = 134.98
                });

            return pedidos;
        }

        static void ExibirResultado(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("{0} - {1}", cliente.Id, cliente.Nome);
                Console.WriteLine("Nascimento: {0}", cliente.Nascimento);
                Console.WriteLine("Sexo: {0}", cliente.Sexo.ToString());
                Console.WriteLine("Email: {0}", cliente.Email);
                Console.WriteLine("********************************");
                Console.WriteLine();
            }
        }
    }
}
