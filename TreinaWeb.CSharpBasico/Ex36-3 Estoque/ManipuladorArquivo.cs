using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_3_Estoque
{
    public class ManipuladorArquivo
    {
        private static string EnderecoArquivo = AppDomain.CurrentDomain.BaseDirectory + "produtos.txt";

        public static List<Produto> Ler()
        {
            List<Produto> produtosCadastrados = new List<Produto>();
            if (File.Exists(@EnderecoArquivo))
            {
                using(StreamReader sr = new StreamReader(@EnderecoArquivo))
                {
                    while (sr.Peek() >= 0)
                    {
                        string linha = sr.ReadLine();
                        string[] linhaSeparada = linha.Split(';');
                        if (linhaSeparada.Count() == 3)
                        {
                            Produto produto = new Produto()
                            {
                                Nome = linhaSeparada[0],
                                Valor = float.Parse(linhaSeparada[1]),
                                Quantidade = int.Parse(linhaSeparada[2])
                            };
                            produtosCadastrados.Add(produto);
                        }
                        else
                        {
                            throw new Exception("O formato do arquivo de produtos é inválido.");
                        }
                    }
                }
            }else
            {
                throw new FileNotFoundException("O arquivo de produtos não foi encontrado.");
            }
            return produtosCadastrados;
        }

        public static void Escrever(List<Produto> produtosCadastrados)
        {
            using(StreamWriter sw = new StreamWriter(@EnderecoArquivo))
            {
                foreach(Produto produto in produtosCadastrados)
                {
                    string linha = produto.ToString();
                    sw.WriteLine(linha);
                }
                sw.Flush();
            }
        }
    }
}
