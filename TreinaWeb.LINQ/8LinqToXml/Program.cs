using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _8LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Os dois métodos abaixo comparam a utilização dos frameworks DOM e LINQ para
             * a criação de arquivos XML. Inspecionando a definição de ambos, pode-se perceber
             * que o método com o LINQ fica muito mais enxuto. */

            //string caminhoArquivoDOM = @"C:\Users\Henrique Baron\Desktop\ContatosDOM.xml";
            //CriarXmlDOM(caminhoArquivoDOM);
            string caminhoArquivoLINQ = @"C:\Users\Henrique Baron\Desktop\ContatosLINQ.xml";
            CriarXmlLinq(caminhoArquivoLINQ);

            Console.WriteLine();

            // Abaixo é demonstrada a consulta aos dados de um arquivo XML com o LINQ.

            // 1. Obtém a fonte de dados
            XDocument document = XDocument.Load(caminhoArquivoLINQ);

            //ExibirSemObjetos(document);
            ExibirComObjetos(document);

            Console.ReadKey();
        }

        /// <summary>
        /// Demonstração de uma consulta LINQ para exibir os dados do XML, diretamente como
        /// extraídos em strings.
        /// </summary>
        /// <param name="document"></param>
        private static void ExibirSemObjetos(XDocument document)
        {
            // 2. Cria a consulta
            IEnumerable<XElement> contatos = from c in document.Descendants("Contato")
                                             where c.Element("Endereco").Element("Bairro").Value == "Bairro XXX"
                                             select c;
            // Em sintaxe de método
            //IEnumerable<XElement> contatos = document.Descendants("Contato").Where(c => c.Element("Endereco").Element("Bairro").Value == "Bairro XXX");

            // 3. Exibe os resultados
            foreach (XElement contato in contatos)
            {
                Console.WriteLine(contato.Element("Nome").Value);

                Console.WriteLine("\nTelefones:");

                XElement telefones = contato.Element("Telefones");
                foreach (XElement telefone in telefones.Elements("Telefone"))
                {
                    string tipo = telefone.Attribute("Tipo").Value;
                    string numero = telefone.Value;

                    Console.WriteLine("{0}: {1}", tipo, numero);
                }

                Console.WriteLine("\nEndereço:");

                XElement endereco = contato.Element("Endereco");
                Console.WriteLine(endereco.Element("Logradouro").Value);
                Console.WriteLine("Bairro: {0}", endereco.Element("Bairro").Value);
                Console.WriteLine("Cidade: {0}", endereco.Element("Cidade").Value);
                Console.WriteLine("Estado: {0}", endereco.Element("Estado").Value);
                Console.WriteLine("CEP: {0}", endereco.Element("CEP").Value);
            }
        }

        /// <summary>
        /// Demonstração de uma consulta LINQ para exibir os dados do XML, instanciando
        /// objetos POCO a partir dos dados lidos.
        /// </summary>
        /// <param name="document"></param>
        private static void ExibirComObjetos(XDocument document)
        {
            // 2. Cria a consulta
            var contatos = from c in document.Descendants("Contato")
                           select new Contato
                           {
                               Nome = c.Element("Nome").Value,
                               Endereco = new Endereco
                               {
                                   Logradouro = c.Element("Endereco").Element("Logradouro").Value,
                                   Bairro = c.Element("Endereco").Element("Logradouro").Value,
                                   Cidade = c.Element("Endereco").Element("Cidade").Value,
                                   Estado = c.Element("Endereco").Element("Estado").Value,
                                   CEP = c.Element("Endereco").Element("CEP").Value
                               }
                           };
            //Em sintaxe de método
            //var _contatos = document.Descendants("Contato")
            //                .Select(c => new Contato
            //                {
            //                    Nome = c.Element("Nome").Value,
            //                    Endereco = new Endereco
            //                    {
            //                        Logradouro = c.Element("Endereco").Element("Logradouro").Value,
            //                        Bairro = c.Element("Endereco").Element("Logradouro").Value,
            //                        Cidade = c.Element("Endereco").Element("Cidade").Value,
            //                        Estado = c.Element("Endereco").Element("Estado").Value,
            //                        CEP = c.Element("Endereco").Element("CEP").Value
            //                    }
            //                });

            foreach (Contato contato in contatos)
            {
                Console.WriteLine(contato.Nome);

                Endereco endereco = contato.Endereco;
                Console.WriteLine(endereco.Logradouro);
                Console.WriteLine("Bairro: {0}", endereco.Bairro);
                Console.WriteLine("Cidade: {0}", endereco.Cidade);
                Console.WriteLine("Estado: {0}", endereco.Estado);
                Console.WriteLine("CEP: {0}", endereco.CEP);
            }
        }

        static void CriarXmlDOM(string caminhoArquivo)
        {
            // Cria o XmlDocument
            XmlDocument contactsDocument = new XmlDocument();

            // Define a instrução de processamento do arquivo e o elemento raiz
            contactsDocument.AppendChild(contactsDocument.CreateProcessingInstruction
                ("xml", "version='1.0' encoding='UTF-8' standalone='yes'"));
            contactsDocument.AppendChild(contactsDocument.CreateElement("Contatos"));

            // Cria o elemento filho do elemento raiz e o adiciona à raiz
            XmlElement contactElement = contactsDocument.CreateElement("Contato");
            contactsDocument.DocumentElement.AppendChild(contactElement);

            // Cria o elemento filho do elemento contato, atribui um valor e adiciona ao elemento
            XmlElement nameElement = contactsDocument.CreateElement("Nome");
            nameElement.InnerText = "Thiago Mônaco";
            contactElement.AppendChild(nameElement);

            // Cria o elemento filho do elemento contato e o adiciona ao elemento
            XmlElement phonesElement = contactsDocument.CreateElement("Telefones");
            contactElement.AppendChild(phonesElement);

            // Cria o elemento filho do elemento Telefones, atribui valor e atributo e adiciona ao elemento
            XmlElement phoneElement = contactsDocument.CreateElement("Telefone");
            phoneElement.InnerText = "(11) 99999-9999";
            phoneElement.SetAttribute("Tipo", "Celular");
            phonesElement.AppendChild(phoneElement);

            // Cria o elemento filho do elemento Telefones, atribui valor e atributo e adiciona ao elemento
            phoneElement = contactsDocument.CreateElement("Telefone");
            phoneElement.InnerText = "(11) 5555-5555";
            phoneElement.SetAttribute("Tipo", "Residencial");
            phonesElement.AppendChild(phoneElement);

            // Cria o elemento filho do elemento contato e o adiciona ao elemento
            XmlElement addressElement = contactsDocument.CreateElement("Endereco");
            contactElement.AppendChild(addressElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            XmlElement streetElement = contactsDocument.CreateElement("Logradouro");
            streetElement.InnerText = "Rua Xpto, 1234";
            addressElement.AppendChild(streetElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            XmlElement districtElement = contactsDocument.CreateElement("Bairro");
            districtElement.InnerText = "Bairro XXX";
            addressElement.AppendChild(districtElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            XmlElement cityElement = contactsDocument.CreateElement("Cidade");
            cityElement.InnerText = "São Paulo";
            addressElement.AppendChild(cityElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            XmlElement stateElement = contactsDocument.CreateElement("Estado");
            stateElement.InnerText = "SP";
            addressElement.AppendChild(stateElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            XmlElement zipCodeElement = contactsDocument.CreateElement("CEP");
            zipCodeElement.InnerText = "01010-010";
            addressElement.AppendChild(zipCodeElement);


            // Criação de um segundo contato

            contactElement = contactsDocument.CreateElement("Contato");
            contactsDocument.DocumentElement.AppendChild(contactElement);

            // Cria o elemento filho do elemento contato, atribui um valor e adiciona ao elemento
            nameElement = contactsDocument.CreateElement("Nome");
            nameElement.InnerText = "Paulo Pedro";
            contactElement.AppendChild(nameElement);

            // Cria o elemento filho do elemento contato e o adiciona ao elemento
            phonesElement = contactsDocument.CreateElement("Telefones");
            contactElement.AppendChild(phonesElement);

            // Cria o elemento filho do elemento Telefones, atribui valor e atributo e adiciona ao elemento
            phoneElement = contactsDocument.CreateElement("Telefone");
            phoneElement.InnerText = "(11) 88888-8888";
            phoneElement.SetAttribute("Tipo", "Celular");
            phonesElement.AppendChild(phoneElement);

            // Cria o elemento filho do elemento Telefones, atribui valor e atributo e adiciona ao elemento
            phoneElement = contactsDocument.CreateElement("Telefone");
            phoneElement.InnerText = "(11) 3333-3333";
            phoneElement.SetAttribute("Tipo", "Residencial");
            phonesElement.AppendChild(phoneElement);

            // Cria o elemento filho do elemento contato e o adiciona ao elemento
            addressElement = contactsDocument.CreateElement("Endereco");
            contactElement.AppendChild(addressElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            streetElement = contactsDocument.CreateElement("Logradouro");
            streetElement.InnerText = "Rua ABC, 9876";
            addressElement.AppendChild(streetElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            districtElement = contactsDocument.CreateElement("Bairro");
            districtElement.InnerText = "Bairro ABC";
            addressElement.AppendChild(districtElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            cityElement = contactsDocument.CreateElement("Cidade");
            cityElement.InnerText = "São Paulo";
            addressElement.AppendChild(cityElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            stateElement = contactsDocument.CreateElement("Estado");
            stateElement.InnerText = "SP";
            addressElement.AppendChild(stateElement);

            // Cria o elemento filho do elemento Endereco, atribui um valor e adiciona ao elemento
            zipCodeElement = contactsDocument.CreateElement("CEP");
            zipCodeElement.InnerText = "02020-020";
            addressElement.AppendChild(zipCodeElement);

            contactsDocument.Save(caminhoArquivo);
            Console.WriteLine("Criado o arquido XML com DOM em {0}", caminhoArquivo);
        }

        static void CriarXmlLinq(string caminhoArquivo)
        {
            XElement contatos =
                new XElement("Contatos",
                    new XElement("Contato",
                        new XElement("Nome", "Thiago Mônaco"),
                        new XElement("Telefones",
                            new XElement("Telefone", "(11) 99999-9999",
                                new XAttribute("Tipo", "Celular")),
                            new XElement("Telefone", "(11) 5555-5555",
                                new XAttribute("Tipo", "Residencial"))),
                        new XElement("Endereco",
                            new XElement("Logradouro", "Rua Xpto, 1234"),
                            new XElement("Bairro", "Bairro XXX"),
                            new XElement("Cidade", "São Paulo"),
                            new XElement("Estado", "SP"),
                            new XElement("CEP", "01010-010"))),
                    new XElement("Contato",
                        new XElement("Nome", "Paulo Pedro"),
                        new XElement("Telefones",
                            new XElement("Telefone", "(11) 88888-8888",
                                new XAttribute("Tipo", "Celular")),
                            new XElement("Telefone", "(11) 3333-3333",
                                new XAttribute("Tipo", "Residencial"))),
                        new XElement("Endereco",
                            new XElement("Logradouro", "Rua ABC, 9876"),
                            new XElement("Bairro", "Bairro ABC"),
                            new XElement("Cidade", "São Paulo"),
                            new XElement("Estado", "SP"),
                            new XElement("CEP", "02020-020"))));

            contatos.Save(caminhoArquivo);
            Console.WriteLine("Criado o arquivo XML com LINQ em {0}", caminhoArquivo);
        }
    }
}
