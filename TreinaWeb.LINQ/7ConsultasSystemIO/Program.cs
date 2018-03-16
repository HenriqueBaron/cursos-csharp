using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ConsultasSystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este código demonstra o uso de LINQ To Objects para consultas ao sistema de arquivos do Windows.
            string diretorio = System.Environment.SystemDirectory;
            Console.WriteLine(diretorio);

            DirectoryInfo directoryInfo = new DirectoryInfo(diretorio);

            // 1. Obtém a fonte de dados
            var arquivos = directoryInfo.GetFiles("*.*").ToList();

            // 2. Cria a consulta
            var agrupado = from a in arquivos
                           group a by a.Extension into fgroup
                           orderby fgroup.Key
                           select fgroup;
            // Em sintaxe de método
            //var agrupado = arquivos.GroupBy(a => a.Extension).OrderBy(a => a.Key);

            // 3. Exibe o resultado
            foreach (var filegroup in agrupado)
            {
                Console.WriteLine("{0} - {1} arquivo(s)", filegroup.Key, filegroup.Count());

                foreach (var file in filegroup)
                {
                    Console.WriteLine(file.Name);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
