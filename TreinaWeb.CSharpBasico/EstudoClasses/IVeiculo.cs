using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    interface IVeiculo
    {
        string Nome { get; set; }

        string Ligar();
        string Desligar();
        string Abastecer();
        string Desabastecer();
    }
}
