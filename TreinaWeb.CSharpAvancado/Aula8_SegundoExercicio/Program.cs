using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_SegundoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Valores originais da lista");
            ShowList(lista);

            var listaModificada = lista.ApplyModify((list) =>
            {
                var listMod = new List<int>();
                foreach (var item in list)
                {
                    listMod.Add(item * 3 / 2);
                }

                return listMod;
            });

            Console.WriteLine("Valores da lista modificada");
            ShowList(listaModificada);

            Console.ReadKey();
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
