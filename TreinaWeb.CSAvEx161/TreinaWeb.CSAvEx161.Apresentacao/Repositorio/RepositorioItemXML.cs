using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace TreinaWeb.CSAvEx161.Apresentacao.Repositorio
{
    public class RepositorioItemXML : IRepositorioItem
    {
        string caminhoArquivoXml = @"C:\Users\Henrique Baron\Source\Repos\TreinaWeb.CSAvEx161\TreinaWeb.CSAvEx161.Apresentacao" + 
                                    @"\Assets\FonteDados.xml";

        public List<Item> SelecionarTodos(Action<Item> callback)
        {
            // Cria um delegate do tipo Action para a ação que deve ser tomada ao inserir cada item à lista.
            Action<Item> adicaoNovoItem = callback;

            // Carrega o arquivo XML com os dados
            XmlDocument fonteDados = new XmlDocument();
            fonteDados.Load(caminhoArquivoXml);
            List<Item> itens = new List<Item>();

            // Adiciona cada node à lista
            foreach (XmlNode node in fonteDados.SelectNodes("//item"))
            {
                Item novoItem = new Item()
                {
                    Id = Convert.ToInt32(node.Attributes["id"].Value),
                    Nome = node.Attributes["nome"].Value
                };
                itens.Add(novoItem);
                Thread.Sleep(1000); // Simula uma demora na importação do item
                adicaoNovoItem(novoItem); // Executa a ação configurada na chamada do método.
            }
            return itens;
        }
    }
}
