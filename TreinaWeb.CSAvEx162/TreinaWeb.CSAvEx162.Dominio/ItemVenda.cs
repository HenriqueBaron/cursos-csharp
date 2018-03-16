﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.CSAvEx162.Dominio
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public Venda Venda { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
        public double Valor { get; set; }
    }
}
