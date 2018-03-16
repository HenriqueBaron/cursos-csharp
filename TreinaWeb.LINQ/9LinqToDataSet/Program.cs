using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9LinqToDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1. Obtém a fonte de dados
            DataSet dsAdventure = PopularDataSet();
            DataTable dtProduto = dsAdventure.Tables["Product"];

            // 2. Cria a consulta
            IEnumerable<DataRow> produtos = from p in dtProduto.AsEnumerable()
                                            where p.Field<string>("Color") == "Black"
                                            orderby p.Field<string>("Name") descending
                                            select p;
            // Em sintaxe de método:
            //IEnumerable<DataRow> _produtos = dtProduto.AsEnumerable().
            //                                Where(p => p.Field<string>("Color") == "Black").
            //                                OrderByDescending(p => p.Field<string>("Name"));

            // 3. Exibe o resultado
            foreach (DataRow row in produtos)
            {
                Console.WriteLine("{0} \t- {1}", row["ProductNumber"], row["Name"]);
            }
            */

            /* O código abaixo demonstra a obtenção e consulta de dados por um DataSet tipado fortemente. Além disso,
             * ele também popula uma lista de objetos Produto, diferente do exemplo acima. */
            // 1. Obtém a fonte de dados
            DsAdventure dsAdventure = PopularDataSetTipado();
            DsAdventure.ProductDataTable dtProduto = dsAdventure.Product;

            // 2. Cria a consulta
            // Se não fosse populada uma List<Produto>, o tipo da consulta seria IEnumerable<DsAdventure.ProductRow>
            List<Produto> produtos = (from p in dtProduto.AsEnumerable()
                                      where !p.IsColorNull() && p.Color == "Black"
                                      orderby p.Name descending
                                      select new Produto
                                      {
                                          Id = p.ProductID,
                                          Nome = p.Name,
                                          Numero = p.ProductNumber
                                      }).ToList();
            // Em sintaxe de método
            /* List<Produto> _produtos = dtProduto.AsEnumerable().Where(p => !p.IsColorNull() && p.Color == "Black").
                                      OrderByDescending(p => p.Name).
                                      Select(p => new Produto
                                      {
                                          Id = p.ProductID,
                                          Nome = p.Name,
                                          Numero = p.ProductNumber
                                      }).ToList(); */

            // 3. Exibe o resultado
            foreach (Produto p in produtos)
            {
                Console.WriteLine("{0} \t- {1}", p.Numero, p.Nome);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Demonstração do da obteção de um DataSet não-tipado.
        /// </summary>
        /// <returns></returns>
        static DataSet PopularDataSet()
        {
            /* Um DataSet não-tipado é uma coleção de elementos DataRow que correspondem a cada linha da tabela lida. Para obter o conteúdo
             * de cada coluna de uma determinada linha, é utilizado nome da coluna como uma string entre colchetes após o nome do objeto DataRow,
             * como por exemplo, row["ProductNumber"] no método Main. O conteúdo é retornado como string. */

            SqlConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=AdventureWorks;User Id=sa;Password=hb_19079303;");

            SqlCommand command = new SqlCommand("SELECT * FROM Production.Product", connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Product");

            return dataSet;
        }

        /// <summary>
        /// Demonstração da obtenção de um DataSet tipado.
        /// </summary>
        /// <returns></returns>
        static DsAdventure PopularDataSetTipado()
        {
            /* Um DataSet tipado (fortemente tipado) é na verdade uma classe que herda DataSet, mas o especifica de acordo com os dados
             * a serem consultados. Este DataSet é definido pelo arquivo DsAdventure.xsd, em cujo designer é possível fazer uma conexão
             * ao banco de dados com o Gerenciador de Servidores do Visual Studio (menu Exibir) e selecionar qual tabela será incluída
             * no DataSet. Como resultado final, cada linha do DataSet específico é composta por propriedades que representam o conteúdo
             * de cada coluna. No método Main, por exemplo, é possível encontrar as expressões row.ProductNumber ou row.IsColorNull() */
            DsAdventureTableAdapters.ProductTableAdapter tableAdapter = new DsAdventureTableAdapters.ProductTableAdapter();

            DsAdventure ds = new DsAdventure();

            tableAdapter.Fill(ds.Product);
            return ds;
        }
    }
}
