using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_3.GenericsParaClasse
{
    class Program
    {
        static Par<int, string>[] conjunto = {new Par<int, string>(1, "Porsche"),
                                        new Par<int, string>(2,"Daimler"),
                                        new Par<int, string>(3, "Audi"),
                                        new Par<int, string>(4,"Volkswagen")};

        static Par<int, int> parIgual = new Par<int, int>(10, 20);

        static void Main(string[] args)
        {
            Iterar(conjunto);

            Console.WriteLine("\n");

            Console.WriteLine("Valor antes de trocar: {0}", parIgual.ToString());
            Swap(parIgual);
            Console.WriteLine("Valor após trocar: {0}", parIgual.ToString());
            Console.ReadKey();
        }

        private static void Iterar<T,U>(Par<T,U>[] conjunto)
        {
            foreach (Par<T,U> item in conjunto)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void Swap<T>(Par<T,T> valor)
        {
            T aux = valor.Var1;
            valor.Var1 = valor.Var2;
            valor.Var2 = aux;
        }
    }
}
