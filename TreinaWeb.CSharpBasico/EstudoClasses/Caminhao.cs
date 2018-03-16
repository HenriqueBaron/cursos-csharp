using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    class Caminhao : Veiculo
    {
        public override string Ligar()
        {
            return "O caminhão está ligado";
        }

        public override string Desligar()
        {
            return "O caminhão está desligado";
        }

        public override string Abastecer()
        {
            return "O caminhão está abastecido";
        }
    }
}
