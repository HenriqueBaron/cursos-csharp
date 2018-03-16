using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex182MetodoExtensao
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5 };

            // Pelo menos duas abordagens são possíveis para a solução do problema:
            // Abordagem 1: Criar um delegate tipo Func e atribuir a ele o método declarado após o Main
            Func<List<int>, List<int>> operacao = IncrementarItens;
            valores = valores.Modificar(operacao);

            // Abordagem 2: 
            Func<List<int>, List<int>> operacaoLambda = (lista) =>
            {
                List<int> resultado = new List<int>();
                foreach (int item in lista)
                {
                    resultado.Add(item + 1);
                }
                return resultado;
            };
            valores = valores.Modificar(operacaoLambda);

            foreach (int item in valores)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static List<int> IncrementarItens(List<int> lista)
        {
            List<int> resultado = new List<int>();
            foreach (int item in lista)
            {
                resultado.Add(item + 1);
            }
            return resultado;
        }
    }
}
