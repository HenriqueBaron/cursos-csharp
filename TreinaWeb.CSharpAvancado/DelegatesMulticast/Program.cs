using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesMulticast
{
    class Program
    {
        delegate void VerificacaoIdade(int idade);
        static VerificacaoIdade verificadorIdade;

        static void Main(string[] args)
        {
            // Usuário informa se ele é homem ou mulher
            // Usuário também informa a idade
            // Se for homem:
            //  Se tiver menos que 21 anos: "Você ainda está crescendo"
            //  Se ele tiver mais que 21 anos: "Você já cresceu"
            //  Se ele tiver mais que 25 anos: "Você pode carregar bastante peso"
            //  Se ele tiver menos que 25 anos: "Você não pode carregar tanto peso"
            // Se for mulher:
            //  Se tiver menos que 18 anos: "Você ainda está crescendo"
            //  Se ele tiver mais que 18 anos: "Você já cresceu"
            //  Se ele tiver mais que 30 anos: "Você pode carregar bastante peso"
            //  Se ele tiver menos que 30 anos: "Você não pode carregar tanto peso"

            /* De acordo com os parâmetros de sexo e idade fornecidos, uma única lógica "if" configura
             * os métodos que devem ser chamados e enfileira-os na ordem apropriada, para ao final fazer
             * uma única chamada com o parâmetro da idade pelo delegate */
            Console.Write("Digite seu sexo: ");
            string sexoUsuario = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idadeUsuario = Convert.ToInt32(Console.ReadLine());
            if (sexoUsuario.Equals("H"))
            {
                verificadorIdade = new VerificacaoIdade(VerificaIdadeHomem);
                verificadorIdade += VerificaCarregamentoPesoHomem;
            }
            else
            {
                verificadorIdade = new VerificacaoIdade(VerificaIdadeMulher);
                verificadorIdade += VerificaCarregamentoPesoMulher;
            }

            verificadorIdade(idadeUsuario);
            Console.ReadKey();
        }

        // Homens
        static void VerificaIdadeHomem(int idade)
        {
            if (idade < 21)
            {
                Console.WriteLine("Você ainda está crescendo");
            }
            else
            {
                Console.WriteLine("Você já cresceu");
            }
        }

        static void VerificaCarregamentoPesoHomem(int idade)
        {
            if (idade > 25)
            {
                Console.WriteLine("Você pode carregar bastante peso");
            }
            else
            {
                Console.WriteLine("Você não pode carregar tanto peso");
            }
        }

        // Mulheres
        static void VerificaIdadeMulher(int idade)
        {
            if (idade < 18)
            {
                Console.WriteLine("Você ainda está crescendo");
            }
            else
            {
                Console.WriteLine("Você já cresceu");
            }
        }

        static void VerificaCarregamentoPesoMulher(int idade)
        {
            if (idade > 30)
            {
                Console.WriteLine("Você pode carregar bastante peso");
            }
            else
            {
                Console.WriteLine("Você não pode carregar tanto peso");
            }
        }
    }
}
