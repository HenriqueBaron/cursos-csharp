using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex182MetodoExtensao
{
    public static class ListExtensions
    {
        public static List<T> Modificar<T>(this List<T> lista, Func<List<T>, List<T>> modificador)
        {
            return modificador(lista);
        }
    }
}
