using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_1.EstoqueXML.DAO
{
    public static class DAOUtils
    {
        //Implementação das operações relacionadas ao acesso de banco de dados MySQL para este projeto.

        public static DbConnection GetConexao()
        {
            DbConnection conexao = new MySqlConnection(GetConnectionString());
            conexao.Open();
            return conexao;
        }

        private static string GetConnectionString()
        {
            //Cria a string de conexão com o MySQL
            string server = ConfigurationManager.AppSettings["server"].ToString();
            string database = ConfigurationManager.AppSettings["database"].ToString();
            string user = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append(@"Server=");
            sb.Append(server);
            sb.Append(@";Database=");
            sb.Append(database);
            sb.Append(@";Uid=");
            sb.Append(user);
            sb.Append(@";Pwd=");
            sb.Append(password);
            sb.Append(@";");

            return sb.ToString();
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            return conexao.CreateCommand();
        }

        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }

        public static DbParameter GetParametro(string nome, object valor)
        {
            //Cria um parâmetro do MySQL para os comandos
            return new MySqlParameter(nome, valor);
        }
    }
}
