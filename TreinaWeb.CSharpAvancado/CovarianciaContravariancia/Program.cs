using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CovarianciaContravariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            ManipuladorFTP<Nivel2> ftp = new ManipuladorFTP<Nivel2>();

            /* O trecho abaixo demonstra a contravariância ao atribuir à variável armazenador, à qual estava
             * atribuído um tipo Nivel3 (que é o mais específico neste exemplo), o Manipulador de FTP tipado
             * com Nivel2. Isto é, houve uma conversão implícita de um tipo genérico para um mais específico */
            IArmazenavel<Nivel3> armazenador = ftp;

            /*Contudo, o tipo empregado no método Armazenar ainda deve ser Nivel3, pois a variável armazenador
             * foi definida com o tipo Nivel3 */
            armazenador.Armazenar(new Nivel3());


            /* Já o trecho abaixo exemplifica a covariância, ao converter de um tipo mais específico (Nivel2)
             * para outro mais genérico (Nivel1). */
            IRecuperavel<Nivel1> recuperador = ftp;
            Console.WriteLine(recuperador.Recuperar(0));

            Console.ReadKey();
        }
    }
}
