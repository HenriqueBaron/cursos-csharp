using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_SegundoExercicio.Dominio
{
    public class PedidoDetalhe
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }

        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; } 
    }
}
