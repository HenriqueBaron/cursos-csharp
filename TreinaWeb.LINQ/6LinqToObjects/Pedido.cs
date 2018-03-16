using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LinqToObjects
{
    class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime Data { get; set; }
        public double Preco { get; set; }
    }
}
