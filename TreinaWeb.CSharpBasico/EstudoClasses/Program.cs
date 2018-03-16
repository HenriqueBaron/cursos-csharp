using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro ();
            carro.Marca = "Fiat";
            //carro.AntigosDonos = new List<string>();
            //carro.AntigosDonos.Add("João da Silva");
            //Console.WriteLine("A marca do carro é " + carro.Marca);

            Dono donoJoao = new Dono();
            donoJoao.Nome = "João";
            donoJoao.Idade = 30;

            Dono donoMaria = new Dono();
            donoMaria.Nome = "Maria";
            donoMaria.Idade = 28;

            carro.AdicionarAntigoDono(donoJoao);
            carro.AdicionarAntigoDono(donoMaria);
            foreach (Dono dono in carro.GetAntigosDonos())
            {
                Console.WriteLine("Um dos antigos donos é {0}, que tem idade de {1} anos.", dono.Nome, dono.Idade);
            }
            Console.WriteLine(carro.Ligar());

            //Construtor com parâmetro opcional
            Carro carro5 = new Carro("Ford", "Ka");
            Console.WriteLine("Este carro é da marca {0}, modelo {1}, e possui {2} portas.", carro5.Marca, carro5.Nome, carro5.NumeroPortas);

            //Construtor de parâmetros nomeados
            Carro carro6 = new Carro(nome: "Ka", marca: "Ford", quantidadePortas: 2);
            Console.WriteLine("Este carro é da marca {0}, modelo {1}, e possui {2} portas.", carro6.Marca, carro6.Nome, carro6.NumeroPortas);

            //Construtor anônimo
            Carro carro7 = new Carro
            {
                Nome = "Astra",
                Marca = "GM",
                NumeroPortas = 4,
                Potencia = 1.4
            };

            Console.WriteLine("Já este carro se chama {0}, é da marca {1}, possui {2} portas e tem motor {3}", 
                carro7.Nome,
                carro7.Marca,
                carro7.NumeroPortas,
                carro7.Potencia);

            Moto moto1 = new Moto()
            {
                Nome = "Titan",
                Marca = "Honda",
                Potencia = 150,
                CapacidadeTanque = 15,
            };

            Console.WriteLine("Essa moto se chama {0}, da marca {1}, com potência de {2} e capacidade do tanque de {3}",
                moto1.Nome,
                moto1.Marca,
                moto1.Potencia,
                moto1.CapacidadeTanque);

            Carro carroFord = new Carro();
            carroFord.Nome = "Ka";
            carroFord.Marca = "Ford";
            Console.WriteLine(carroFord.Ligar());

            //Demonstração dos métodos herdados da classe Object
            Console.WriteLine("GetHashCode = " + carroFord.GetHashCode());
            Console.WriteLine("ToString = " + carroFord.ToString());
            Console.WriteLine("Equals = " + carroFord.Equals(carro7));

            //Criação de uma nova classe com os mesmos dados de outra. Teste com uma sobrecarga do método Object.Equals() específica
            //para a classe Carro
            Carro carroFord2 = new Carro("Ford", "Ka");
            Console.WriteLine("Equals = " + carroFord.Equals(carroFord2));

            //Lição de polimorfismo
            Veiculo meuCarro = new Carro();
            Veiculo minhaMoto = new Moto();
            Console.WriteLine("Ligando o carro: " + meuCarro.Ligar());
            Console.WriteLine("Ligando a moto: " + minhaMoto.Ligar());
            Console.WriteLine("Desligando o carro: " + meuCarro.Desligar());
            Console.WriteLine("Desligando a moto: " + minhaMoto.Desligar());
            Console.WriteLine("Abastecendo o carro: {0}", meuCarro.Abastecer());
            Console.WriteLine("Desabastecendo o carro: {0}", meuCarro.Desabastecer());
            Console.WriteLine("Abastecendo a moto: {0}", minhaMoto.Abastecer());
            Console.WriteLine("Desabastecendo a moto: {0}", minhaMoto.Desabastecer());

            //Implementação a partir de uma interface
            IVeiculo meuCaminhao = new Caminhao();
            Console.WriteLine("Mensagem do caminhão: {0}", meuCaminhao.Ligar());
            Console.WriteLine("Abastecendo o caminhão: {0}", meuCaminhao.Abastecer());
            Console.WriteLine("Desabastecendo o caminhão: {0}", meuCaminhao.Desabastecer());

            Console.ReadKey();
        }
    }
}
