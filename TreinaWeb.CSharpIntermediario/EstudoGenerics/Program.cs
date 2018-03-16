using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa
            {
                Id = 1,
                Nome = "Treinaweb"
            };

            Animal animal = new Animal
            {
                Id = 1,
                Especie = "Cachorro"
            };

            //Teste sem o uso de Generics, com os as classes específicas para cada tipo.
            //RepositorioPessoa repositorioPessoa = new RepositorioPessoa();
            //RepositorioAnimal repositorioAnimal = new RepositorioAnimal();

            //Teste com o uso de Generics, utilizando uma classe genérica.
            RepositorioGenerico<Pessoa> repositorioPessoa = new RepositorioGenerico<Pessoa>();
            RepositorioGenerico<Animal> repositorioAnimal = new RepositorioGenerico<Animal>();

            repositorioPessoa.Insert(pessoa);
            repositorioAnimal.Insert(animal);

            foreach (Pessoa p in repositorioPessoa.Get())
            {
                Console.WriteLine("Nome da pessoa: " + p.Nome);
            }

            foreach (Animal a in repositorioAnimal.Get())
            {
                Console.WriteLine("Especie do animal: " + a.Especie);
            }



            Console.ReadKey();
        }
    }
}
