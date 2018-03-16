using CadastroPessoas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.Persistencia.EF
{
    /// <summary>
    /// A classe-pai DbContext representa no Entity Framework um banco de dados. É uma classe abstrata, que é herdada então por outras
    /// classes de modo a criar os bancos de dados específicos.
    /// Já a classe DbSet é responsável pela representação de uma tabela do banco de dados. Como demonstrado abaixo, ela é declarada
    /// como uma propriedade da classe herdeira de DbContext, e sendo genérica, é especificada com uma classe POCO (Plain-old CLR Object).
    /// </summary>
    public class CadastroPessoasDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }

    /* OBSERVAÇÃO IMPORTANTE: Para a conexão com SQL Server (ou qualquer outra base de dados) através do Entity Framework, alguns passos
     * precisam ser tomados. Primeiramente, adicionou-se via NuGet o EntityFramework a este projeto. Então, após configurar a connection
     * string conforme comentado no arquivo "App.config", a pasta Migrations deste projeto e seu conteúdo precisaram ser gerados. Para
     * isso, os seguintes comandos foram fornecidos no Console do Gerenciador de Pacotes:
     *      1. "Enable-Migrations -ProjectName <Nome do projeto> -StartUpProjectName <Nome do projeto>"
     *      2. "Add-Migration "Criacao_Tabela_Pessoas" -ProjectName <Nome do projeto> -StartUpProjectName <Nome do projeto>"
     *          O nome Criacao_Tabela_Pessoas corresponde ao nome da classe gerada na pasta Migrations
     *      3. "Update-Database -ProjectName <Nome do projeto> -StartUpProjectName <Nome do projeto>"
     *          O parâmetro -Verbose pode ser acrescentado ao final apenas para exibir o código SQL gerado. */
}
