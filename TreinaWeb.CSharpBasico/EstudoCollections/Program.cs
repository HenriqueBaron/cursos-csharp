using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> listaNumeros = new List<int>();
            //listaNumeros.Add(1);
            //listaNumeros.Add(2);

            for (int i = 0; i < 20; i++)
            {
                listaNumeros.Add(i);
            }
            listaNumeros.Remove(5);
            listaNumeros.RemoveAt(2);
            listaNumeros.Reverse();
            Console.WriteLine("O índice do número 15 é " + listaNumeros.IndexOf(15));
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            */

            /*Dictionary<string, string> meuDicionario = new Dictionary<string, string>();
            meuDicionario.Add("Adicionar", "Adicionar significa somar");
            meuDicionario.Add("Subtrair", "Subtrair sifnigica diminuir");

            foreach(string chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} - {1}", chave, meuDicionario[chave]);
            }*/

            Dictionary<int, string> meuDicionario = new Dictionary<int, string>();
            meuDicionario.Add(1, "Numero baixo");
            meuDicionario.Add(5, "Numero médio");
            meuDicionario.Add(8, "Numero alto");
            foreach(int chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} é um {1}", chave, meuDicionario[chave]);
            }

            Console.ReadKey();
        }
    }
}
