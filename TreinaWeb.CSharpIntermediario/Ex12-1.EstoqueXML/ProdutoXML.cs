using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ex12_1.EstoqueXML
{
    public class ProdutoXML
    {
        public int Id { get; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        private ProdutoXML(int id, string descricao, double preco, int quantidade)
        {
            //Construtor privado que permite escrever a propriedade Id.
            Id = id;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
        }

        public ProdutoXML(string descricao, double preco, int quantidade)
        {
            //Construtor público que gera um Id automaticamente
            Id = CarregarIdAtual() + 1;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
        }

        public static List<ProdutoXML> ObterProdutos()
        {
            //Retorna do arquivo XML uma Collection com os produtos.
            XmlDocument fonteDados = XMLUtils.GetArquivo();
            XmlNodeList nodesProdutos = fonteDados.SelectNodes("//produto");
            List<ProdutoXML> listaProdutos = new List<ProdutoXML>();
            foreach (XmlNode nodeProduto in nodesProdutos)
            {
                ProdutoXML produto = ProdutoXML.ObterDeNode(nodeProduto);
                listaProdutos.Add(produto);
            }
            return listaProdutos;
        }

        public static void AdicionarProduto(ProdutoXML produto)
        {
            //Acrescenta o produto especificado ao arquivo XML.
            XmlDocument fonteDados = XMLUtils.GetArquivo();
            XmlNode nodeProduto = ProdutoXML.CriarXmlNode(produto, fonteDados);
            XmlNode conjuntoProdutos = fonteDados.SelectSingleNode("//produtos");
            conjuntoProdutos.AppendChild(nodeProduto);
            XMLUtils.SalvarArquivo(fonteDados);
        }

        public static void SubstituirProduto(ProdutoXML produtoNovo, ProdutoXML produtoAnterior)
        {
            //Substitui o produto especificado em produtoAnterior pelo fornecido em produtoNovo.
            XmlDocument fonteDados = XMLUtils.GetArquivo();

            XmlNode nodeProdutoNovo = ProdutoXML.CriarXmlNode(produtoNovo, fonteDados);
            XmlNode nodeProdutoAnterior = ProdutoXML.EncontrarProduto(produtoAnterior, fonteDados);

            XmlNode conjuntoProdutos = fonteDados.SelectSingleNode("//produtos");
            conjuntoProdutos.ReplaceChild(nodeProdutoNovo, nodeProdutoAnterior);
            XMLUtils.SalvarArquivo(fonteDados);
        }

        public static void ExcluirProduto(ProdutoXML produto)
        {
            //Apaga do arquivo o produto especificado.
            XmlDocument fonteDados = XMLUtils.GetArquivo();
            XmlNode nodeProduto = ProdutoXML.EncontrarProduto(produto, fonteDados);
            XmlNode conjuntoProdutos = fonteDados.SelectSingleNode("//produtos");
            conjuntoProdutos.RemoveChild(nodeProduto);
            XMLUtils.SalvarArquivo(fonteDados);
        }

        private int CarregarIdAtual()
        {
            //Busca no arquivo XML o último Id cadastrado.
            XmlDocument fonteDados = XMLUtils.GetArquivo();
            XmlNodeList produtos = fonteDados.SelectNodes("//produto");
            XmlNode ultimoProduto = produtos[produtos.Count - 1];
            return Convert.ToInt32(ultimoProduto.Attributes["id"].Value);
        }

        private static XmlNode EncontrarProduto(ProdutoXML produto, XmlDocument fonteDados)
        {
            //Encontra no documento XML especificado um nó que corresponda ao produto fornecido.
            XmlNodeList conjuntoProdutos = fonteDados.SelectNodes("//produto");
            foreach (XmlNode nodeProduto in conjuntoProdutos)
            {
                ProdutoXML produtoConvertido = ObterDeNode(nodeProduto);
                if (produtoConvertido.Equals(produto))
                {
                    return nodeProduto;
                }
            }
            return null;
        }

        public bool Equals(ProdutoXML produto)
        {
            //Compara se as propriedades de dois produtos são idênticas
            return (this.Id == produto.Id &&
                this.Descricao == produto.Descricao &&
                this.Preco == produto.Preco &&
                this.Quantidade == produto.Quantidade);
        }

        private static ProdutoXML ObterDeNode(XmlNode produto)
        {
            //Lê um XmlNode do produto e o transforma em um objeto do tipo ProdutoXML
            int id = Convert.ToInt32(produto.Attributes["id"].Value);
            string descricao = produto.Attributes["descricao"].Value;
            double preco = Convert.ToDouble(produto.Attributes["preco"].Value);
            int quantidade = Convert.ToInt32(produto.Attributes["quantidade"].Value);
            return new ProdutoXML(id, descricao, preco, quantidade);
        }

        private static XmlNode CriarXmlNode(ProdutoXML produto, XmlDocument fonteDados)
        //Transforma um objeto do tipo ProdutoXML em um XmlNode contendo as propriedades do produto
        //em seus atributos.
        {
            XmlNode node = fonteDados.CreateElement("produto");
            foreach (XmlAttribute atributo in CriarAtributos(produto, fonteDados))
            {
                node.Attributes.Append(atributo);
            }
            return node;
            
        }

        private static List<XmlAttribute> CriarAtributos(ProdutoXML produto, XmlDocument fonteDados)
        {
            //Cria atributos de um elemento XML com as propriedades do produto especificado.
            XmlAttribute atributoId = fonteDados.CreateAttribute("id");
            atributoId.Value = produto.Id.ToString();

            XmlAttribute atributoDescricao = fonteDados.CreateAttribute("descricao");
            atributoDescricao.Value = produto.Descricao;

            XmlAttribute atributoPreco = fonteDados.CreateAttribute("preco");
            atributoPreco.Value = produto.Preco.ToString();

            XmlAttribute atributoQuantidade = fonteDados.CreateAttribute("quantidade");
            atributoQuantidade.Value = produto.Quantidade.ToString();

            return new List<XmlAttribute> { atributoId, atributoDescricao, atributoPreco, atributoQuantidade };
        }
    }
}
