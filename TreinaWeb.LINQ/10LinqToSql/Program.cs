using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este exemplo demonstra a consulta LINQ a um banco de dados SQL, utilizando também tabelas relacionadas por chaves estrangeiras, retornando
            // ambos os objetos da relação.
            AdventureWorks aw = new AdventureWorks(@"Server=.\SQLEXPRESS;Database=AdventureWorks;User Id=sa;Password=hb_19079303;");

            // 1. Obtém a fonte de dados: a fonte já existe e é o próprio servidor. A classe AdventureWorks, filha de DataContext,
            //    é responsável por fazer a conexão

            // 2. Cria a consulta
            var result = from pc in aw.ProductCategories
                         orderby pc.Name
                         select new
                         {
                             Nome = pc.Name,
                             SubCategorias = pc.ProductSubCategories
                         };
            // Em sintaxe de método
            /* var _result = aw.ProductCategories.OrderBy(pc => pc.Name).
                          Select(pc => new
                          {
                              Nome = pc.Name,
                              SubCategorias = pc.ProductSubCategories
                          }); */

            foreach (var item in result)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Subcategorias de {0}:", item.Nome);
                foreach (var subitem in item.SubCategorias)
                {
                    Console.WriteLine(subitem.Name);
                }
                Console.WriteLine("*************************************");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
