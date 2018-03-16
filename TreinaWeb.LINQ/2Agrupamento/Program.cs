using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Agrupamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Obtém a fonte de dados
            // O tipo Dictionary não é o elemento de estudo do curso, mas forma uma lista de itens 
            // contendo uma key (o nome da pessoa) e um valor (a idade)
            Dictionary<string, int> pessoas = new Dictionary<string, int>();
            pessoas.Add("Pedro", 50);
            pessoas.Add("Maria", 40);
            pessoas.Add("Thiago", 30);
            pessoas.Add("José", 40);
            pessoas.Add("João", 30);
            pessoas.Add("Roberta", 50);

            // 2. Prepara a consulta, agrupamento as pessoas pela propriedade Value dos itens no Dictionary,
            // que corresponde à idade.
            var pessoasPorIdade = from p in pessoas
                                  group p by p.Value;

            // 3. Realiza a consulta e retorna o resultado.
            /* Nota: não confundir a propriedade Key do objeto "idade" com Key do objeto "pessoa". idade
             é um objeto do tipo IGrouping<> que é o retorno de uma consulta LINQ com agrupamento. Essa interface,
             por acaso, também é composta por uma Key e por uma coleção de elementos, parecido com o Dictionary.
             Mas no caso do objeto idade, Key é a respectiva idade pela qual as pessoas foram agrupadas, e os
             elementos da coleção são os objetos pessoa do segundo foreach.
             Isso demonstra que o objeto IEnumerable pessoasPorIdade, por ter utilizado agrupamento, tornou-se
             uma coleção de coleções. */
            foreach (var idade in pessoasPorIdade)
            {
                Console.WriteLine("Pessoas com {0} anos:", idade.Key);
                foreach (var pessoa in idade)
                {
                    Console.WriteLine("A pessoa {0} tem {1} anos.", pessoa.Key, pessoa.Value);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
