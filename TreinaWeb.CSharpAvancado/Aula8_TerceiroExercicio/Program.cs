using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_TerceiroExercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lista1 = new List<int>() { 1, 2, 4, 6, 102, 30, 21, 43 };
            var lista2 = new List<int>() { 30, 3, 7, 201, 21, 27, 2, 9, 171 };

            Console.WriteLine("Valores da lista1");
            ShowList(lista1);

            Console.WriteLine("Valores da lista2");
            ShowList(lista2);

            ShowEquals(lista1, lista2);

            ShowNotEquals(lista1, lista2);

            Console.ReadKey();
        }


        public static void ShowEquals(List<int> lista1, List<int> lista2)
        {
            var lista = new List<int>();

            foreach (var item1 in lista1)
                foreach (var item2 in lista2)
                    if (item1 == item2)
                        lista.Add(item1);

            Console.WriteLine("Valores iguais em ambas as listas");
            ShowList(lista);
        }

        public static void ShowNotEquals(List<int> lista1, List<int> lista2)
        {
            var lista = new List<int>();

            foreach (var item in lista1)
                if (!lista2.Contains(item))
                    lista.Add(item);

            foreach (var item in lista2)
                if (!lista1.Contains(item))
                    lista.Add(item);

            Console.WriteLine("Valores únicos em uma das listas");
            ShowList(lista);
        }

        private static void ShowList(List<int> lista)
        {
            foreach (var item in lista.Distinct())
            {
                Console.WriteLine(item);
            }
        }
    }
}
