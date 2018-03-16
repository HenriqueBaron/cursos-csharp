using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ex12_1.EstoqueXML
{
    public static class XMLUtils
    {
        public static XmlDocument GetArquivo()
        {
            string caminhoArquivo = ConfigurationManager.AppSettings["XMLpath"].ToString();
            XmlDocument origemDados = new XmlDocument();
            origemDados.Load(@caminhoArquivo);
            return origemDados;
        }

        public static string GetTitulo(string caminho)
        {
            XmlDocument origemDados = GetArquivo();
            XmlNode nodeTitulo = origemDados.SelectSingleNode(caminho);
            return nodeTitulo.InnerText;
        }

        public static void SalvarArquivo(XmlDocument arquivo)
        {
            arquivo.Save(ConfigurationManager.AppSettings["path"].ToString());
        }
    }
}
