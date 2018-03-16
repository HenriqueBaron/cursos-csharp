using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoGenerics
{
    //Os símbolos < > após o nome da classe indicam o uso de Generics, sendo o tipo desejado salvo na variável T
    //ao criar um objeto da classe.
    public class RepositorioGenerico<T>
    {
        private List<T> lista;

        public RepositorioGenerico()
        {
            lista = new List<T>();
        }

        public List<T> Get()
        {
            return lista;
        }

        public void Insert(T item)
        {
            lista.Add(item);
        }

    }
}
