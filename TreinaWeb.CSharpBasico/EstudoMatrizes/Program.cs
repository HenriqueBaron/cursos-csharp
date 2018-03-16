using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] minhaMatriz = new int[2, 4];
            int numero = 0;
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    minhaMatriz[i, j] = numero;
                    numero++;
                }
            }
            for (int i=0; i <=1; i++)
            {
                for (int j=0; j<=3; j++)
                {
                    Console.WriteLine("minhaMatriz[{0}, {1}] = {2}", i, j, minhaMatriz[i, j]);
                }
            }
            Console.WriteLine("Quantidade de dimensões: " + minhaMatriz.Rank);
            Console.WriteLine("Tamanho da matriz: " + minhaMatriz.Length);
            Console.ReadKey();
        }
    }
}
