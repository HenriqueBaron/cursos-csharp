using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_SegundoExercicio.Dominio
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }

        public virtual List<PedidoDetalhe> Detalhes { get; set; }

        public Pedido()
        {
            Detalhes = new List<PedidoDetalhe>();
        }
    }
}
