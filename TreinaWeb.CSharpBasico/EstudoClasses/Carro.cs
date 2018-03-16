using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public class Carro : Veiculo
    {

        public int NumeroPortas { get; set; }

        private List<Dono> antigosDonos;

        public Carro()
        {
            this.antigosDonos = new List<Dono>();
        }

        public Carro(string marca, string nome, int quantidadePortas = 4)
        {
            this.Marca = marca;
            this.Nome = nome;
            this.NumeroPortas = quantidadePortas;
        }

        public void AdicionarAntigoDono(Dono nome)
        {
            antigosDonos.Add(nome);
        }

        public List<Dono> GetAntigosDonos()
        {
            return antigosDonos;
        }

        //public string Ligar()
        //{
        //    if (EhFord)
        //    {
        //        return "O carro agora está ligado igual carro da Ford";
        //    }
        //    else
        //    {
        //        return "O carro agora está ligado";
        //    }
        //}

        public override string Ligar()
        {
            return "O carro está ligado";
        }

        public override string Desligar()
        {
            return "O carro está desligado";
        }

        public override bool Equals(object obj)
        {
            Carro carro2 = (Carro)obj;
            return carro2.Nome == this.Nome && carro2.Marca == this.Marca;
        }

        public override string ToString()
        {
            return string.Format("Carro: Nome = {0}, Marca = {1}", this.Nome, this.Marca);
        }

        public override string Abastecer()
        {
            return "O carro está abastecido";
        }
    }
}
