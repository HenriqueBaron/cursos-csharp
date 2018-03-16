using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesGenericos
{
    class Program
    {
        
        // Sendo genérico, este delegate pode receber qualquer um dos dois métodos Somar e SomarDecimal
        delegate T CalculoMatematico<T>(T a, T b);

        // Uma outra maneira de tornar ainda mais simples as linhas de código acima é utilizar o delegate
        // genérico Func<>, provido pelo próprio ambiente de programação.


        static void Main(string[] args)
        {
            Program p = new Program();

            // Trocando o tipo do delegate (<int> ou <decimal>) na sua construção, pode-se trabalhar com
            // diferentes tipos
            //CalculoMatematico<int> calculo = new CalculoMatematico<int>(p.Somar);
            //Console.WriteLine(calculo(1, 1));

            /* Da nesna forma, delegates podem ser utilizados como parâmetros de métodos. O método abaixo
             * recebe como entrada o delegate de tipo CalculoMatematico<T>
             * Importante: não foi preciso definir o tipo do delegate ao chamar o método (por exemplo,
             * entrar com "ExibirInformacoesDelegate<int>(calculo)" ). Isso porque o compilador utiliza a inferência
             * para determinar o tipo, uma vez que, algumas linhas acima, já definimos que a instância "calculo"
             * do delegate é de tipo "int" */
            //ExibirInformacoesDelegate(calculo);

            /* O código acima foi comentado para que os testes com o delegate genérico Func fossem feitos. Para
             * voltar a utilizar o delegate explícito, é necessário apenas "descomentar" as linhas acima deste
             * comentário e comentar as linhas abaixo que utilizam o delegate Func<>. */

            Func<int, int, int> calculo = p.Somar;

            /* Da mesma forma, para testar o uso do delegate genérico Action<>, o método Console.WriteLine()
             * foi encapsulado no método ImprimirResultado() */
            Action<int> impressao = p.ImprimirResultado;
            impressao(calculo(1, 1));

            Console.ReadKey();
        }

        private static void ExibirInformacoesDelegate<T>(CalculoMatematico<T> calculo)
        {
            Console.WriteLine(calculo.Target);
            Console.WriteLine(calculo.Method);
        }

        void ImprimirResultado(int resultado)
        {
            Console.WriteLine(resultado);
        }

        int Somar(int a, int b)
        {
            return a + b;
        }

        decimal SomarDecimal(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
