using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstudoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // TESTE A: Todas as pessoas com mais de dois irmãos

            // 1. Passo: definir a fonte de dados
            List<Pessoa> pessoas = CarregarListaPessoa();

            /* O trecho abaixo demonstra a forma tradicional de realizar consultas LINQ. Este passo 2 foi
             * comentado para dar espaço ao trecho onde a consulta é repetida utilizando os métodos de extensão
             * do namespace Linq.Expressions.
            // 2. Passo: definir a consulta
            IEnumerable<Pessoa> pessoasMaisDeDoisIrmaos = from pessoa in pessoas //Fonte de dados e variável
                                          where pessoa.QuantidadeIrmaos > 2 //Filtragem
                                          select pessoa; //Projeção
            */

            //Código equivalente para este caso
            /* List<Pessoa> pessoasMaisDeDoisIrmaos = new List<Pessoa>();
            foreach (var pessoa in pessoas)
            {
                if (pessoa.QuantidadeIrmaos > 2)
                {
                    pessoasMaisDeDoisIrmaos.Add(pessoa);
                }
            }
            */

            // 2. Passo: definir a consulta (Métodos do Linq.Expressions)
            IEnumerable<Pessoa> pessoasMaisDeDoisIrmaos = pessoas.Where(p => p.QuantidadeIrmaos > 2);

            // 3. Consulta ao resultado
            foreach (Pessoa p in pessoasMaisDeDoisIrmaos)
            {
                Console.WriteLine("{0} {1} {2}", p.Nome, p.Idade, p.QuantidadeIrmaos);
            }

            Console.WriteLine("*****************************************************");

            //TESTE B: Todas as pessoas maiores de idade
            // 1. Passo: já executado no teste A

            /* O trecho abaixo demonstra a forma tradicional de realizar consultas LINQ. Este passo 2 foi
             * comentado para dar espaço ao trecho onde a consulta é repetida utilizando os métodos de extensão
             * do namespace Linq.Expressions.
            // 2. Passo
            var pessoasMaioresDeIdade = from pessoa in pessoas
                                        where pessoa.Idade >= 18
                                        orderby pessoa.Idade descending, pessoa.Nome
                                        select new { pessoa.Nome, pessoa.Idade };
            */
            
            /* Observações: - neste caso, o tipo IEnumerable<> não foi declarado para pessoasMaioresDeIdade. Apenas
             *                foi utilizada a keyword var. Isso é permitido, pois o compilador vai realizar
             *                inferência de tipo.
             *              - Foi estabelecida uma ordenação descrescente da idade
             *              - Como não se desejava obter no resultado a quantidade de irmãos das pessoas, um tipo
             *                anônimo foi criado no momento da projeção.
             */

            // 2. Passo: definir a consulta (Métodos do Linq.Expressions)
            var pessoasMaioresDeIdade = pessoas.Where(pessoa => pessoa.Idade > 18).OrderByDescending(qualquerNome => qualquerNome.Idade)
                                        .ThenBy(pessoa => pessoa.Nome.Length)
                                        .Select(pessoa => new { pessoa.Nome, pessoa.Idade });

            // 3. Passo
            foreach (var pessoa in pessoasMaioresDeIdade)
            {
                Console.WriteLine("{0}, {1}", pessoa.Nome, pessoa.Idade);
            }

            Console.ReadKey();
        }

        static List<Pessoa> CarregarListaPessoa()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa
            {
                Nome = "João",
                Idade = 18,
                QuantidadeIrmaos = 2
            });
            pessoas.Add(new Pessoa
            {
                Nome = "Maria",
                Idade = 30,
                QuantidadeIrmaos = 0
            });
            pessoas.Add(new Pessoa
            {
                Nome = "José",
                Idade = 50,
                QuantidadeIrmaos = 6
            });
            return pessoas;
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadeIrmaos { get; set; }
    }
}
