using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            //Abre o arquivo XML de configuração App.config e obtém a string de conexão, selecionando também o banco de dados que será utilizado.
            //Para utitilizá-lo, foi preciso acrescentar a DLL System.Configuration clicando com o botão direito sobre o nome do projeto e selecionando
            //Adicionar > Referência. Esta DLL não foi baixada do NuGet (como foi o caso da biblioteca não-nativa do MySQL) porque apesar de não ser
            //padrão no projeto, ela é parte do .NET Framework.

            string server = ConfigurationManager.AppSettings["server"].ToString();
            string database = ConfigurationManager.AppSettings["database"].ToString();
            string user = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            DbConnection conexao = null;

            string providerBancoDados = ConfigurationManager.AppSettings["provider"].ToString();
            if (providerBancoDados == "MSSQL")
            {
                //Implementação para conexão com o banco de dados do SQL Server
                string connectionString = @"Server=" + server +
                                        ";Database=" + database +
                                        ";User Id=" + user +
                                        ";Password=" + password;
                conexao = new SqlConnection(connectionString);
            }
            else if (providerBancoDados == "MYSQL")
            {
                //Implementação para conexão com o banco de dados do MySQL
                string connectionString = @"Server=" + server +
                                         ";Database=" + database + 
                                         ";Uid=" + user +
                                         ";Pwd=" + password + ";";
                conexao = new MySqlConnection(connectionString);
            }
            conexao.Open();
            return conexao;
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }

        public static DbParameter GetParametro(string nome, object valor)
        {
            DbParameter parametro = null;
            string providerBancoDados = ConfigurationManager.AppSettings["provider"].ToString();
            if (providerBancoDados == "MSSQL")
            {
                parametro = new SqlParameter(nome, valor);
            }
            else if (providerBancoDados == "MYSQL")
            {
                parametro = new MySqlParameter(nome, valor);
            }
            return parametro;
        }
    }
}
