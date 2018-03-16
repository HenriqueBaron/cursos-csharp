using Aula16_PrimeiroExercicio.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Aula16_PrimeiroExercicio.Repositorio
{
    public class RepositorioBook
    {
        public delegate void ReadBookEventHandler(object sender, BookEventArgs e);
        public event ReadBookEventHandler ReadBookEvent;

        //private static string EnderecoArquivo = @"..\..\Aula16_PrimeiroExercicio\Assets\catalogo.xml";
        private static string EnderecoArquivo = @"C:\Users\Henrique Baron\Source\Repos\Aula16_PrimeiroExercicio\Assets\catalogo.xml";

        public void LerArquivo()
        {
            if (File.Exists(@EnderecoArquivo))
            {
                XmlDocument docXml = new XmlDocument();
                docXml.Load(EnderecoArquivo);

                foreach (XmlNode node in docXml.SelectNodes("/catalog/book"))
                {
                    var book = new Book
                    {
                        Id = node.Attributes["id"].InnerText,
                        Author = node.SelectSingleNode("author").InnerText,
                        Title = node.SelectSingleNode("title").InnerText,
                        Genre = node.SelectSingleNode("genre").InnerText,
                        Price = Convert.ToDouble(node.SelectSingleNode("price").InnerText),
                        PublishDate = Convert.ToDateTime(node.SelectSingleNode("publish_date").InnerText),
                        Description = node.SelectSingleNode("description").InnerText
                    };

                    OnReadBookClick(new BookEventArgs(book));

                    //Para apaecer um efeito de dados sendo carregados no Grid
                    Thread.Sleep(1000);
                }
            }
        }

        public virtual void OnReadBookClick(BookEventArgs e)
        {
            ReadBookEvent?.Invoke(this, e);
        }
    }
}
