using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_3_Estoque
{
    public class Produto
    {
        public string Nome { get; set; }
        public float Valor { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome = "", float valor = 0, int quantidade = 0)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Quantidade = quantidade;
        }

        public string FormatarParaLista()
        {
            return string.Format("{0} - {1}: {2} disponíveis", this.Nome, this.Valor.ToString("C"), this.Quantidade.ToString());
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2}", this.Nome, this.Valor, this.Quantidade);
        }
    }
}
