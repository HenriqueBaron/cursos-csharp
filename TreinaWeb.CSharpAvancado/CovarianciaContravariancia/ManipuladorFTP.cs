using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CovarianciaContravariancia
{
    public class ManipuladorFTP<T> : IArmazenavel<T>, IRecuperavel<T>
    {
        private List<T> lista = new List<T>();

        public void Armazenar(T item)
        {
            lista.Add(item);
        }

        public T Recuperar(int codigo)
        {
            return lista[codigo];
        }
    }
}
