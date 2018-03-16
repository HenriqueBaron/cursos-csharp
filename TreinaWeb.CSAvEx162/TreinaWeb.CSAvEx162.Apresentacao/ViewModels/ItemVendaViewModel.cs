using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.CSAvEx162.Apresentacao.ViewModels
{
    public class ItemVendaViewModel
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public double ProdutoPreco { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
    }
}
