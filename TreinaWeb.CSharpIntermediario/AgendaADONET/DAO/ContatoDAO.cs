using AgendaADONET.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    public class ContatoDAO
    {
        //Implementação da leitura na forma de DataTable, permitindo apenas leitura do banco de dados
        public DataTable GetContatos()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CONTATOS";
            DbDataReader reader = DAOUtils.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        //Implementação por DataSet, que permite edições na tabela do banco de dados
        /*public DataSet GetContatos()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CONTATOS";
            DbDataAdapter adapter = new SqlDataAdapter((SqlCommand)comando);
            DataSet ds = new DataSet();
            //adapter.Fill(ds);
            adapter.Fill(ds, "CONTATOS"); //Esta sobrecarga permite adicionar um título, ou uma representação da tabela por um nome
            return ds;
        }*/

        public void Excluir(int id)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM CONTATOS WHERE ID = @id";

            comando.Parameters.Add(DAOUtils.GetParametro("@id", id));

            comando.ExecuteNonQuery();
        }

        public void Inserir(Contato contato)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO CONTATOS (NOME, EMAIL, TELEFONE) VALUES (@nome, @email, @telefone)";
            
            comando.Parameters.Add(DAOUtils.GetParametro("@nome", contato.Nome));
            comando.Parameters.Add(DAOUtils.GetParametro("@email", contato.Email));
            comando.Parameters.Add(DAOUtils.GetParametro("@telefone", contato.Telefone));
            comando.ExecuteNonQuery();
        }

        public void Atualizar(Contato contato)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE CONTATOS SET NOME = @nome, EMAIL = @email, TELEFONE = @telefone WHERE ID = @id";

            comando.Parameters.Add(DAOUtils.GetParametro("@nome", contato.Nome));
            comando.Parameters.Add(DAOUtils.GetParametro("@email", contato.Email));
            comando.Parameters.Add(DAOUtils.GetParametro("@telefone", contato.Telefone));
            comando.Parameters.Add(DAOUtils.GetParametro("@id", contato.Id));

            comando.ExecuteNonQuery();
        }

        public int ContarUsuarios()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT COUNT(*) FROM CONTATOS";
            return Convert.ToInt32(comando.ExecuteScalar());
        }

    }
}
