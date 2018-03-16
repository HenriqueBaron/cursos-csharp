using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public abstract class Veiculo : IVeiculo
    {
        private string marca;

        public string Nome { get; set; }
        public string Marca { get; set; }
        //public string Marca
        //{
        //    get
        //    {
        //        return marca;
        //    }
        //    set
        //    {
        //        if (value == "Ford")
        //        {
        //            EhFord = true;
        //        }
        //        else
        //        {
        //            EhFord = false;
        //        }
        //        marca = value;
        //    }
        //}
        public double Potencia { get; set; }
        //protected bool EhFord { get; set; }

        public abstract string Ligar();

        public abstract string Desligar();

        public abstract string Abastecer();

        public string Desabastecer()
        {
            return "O veículo já foi desabastecido";
        }
    }
}
