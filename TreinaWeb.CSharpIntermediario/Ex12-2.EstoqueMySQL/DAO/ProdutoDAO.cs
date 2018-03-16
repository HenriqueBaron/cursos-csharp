using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_1.EstoqueXML.DAO
{
    public class ProdutoDAO
    {
        public struct Produto
        {
            public int Id { get; set; }
            public string Descricao { get; set; }
            public double Preco { get; set; }
            public int Quantidade { get; set; }
        }

        public static DataTable GetProdutos()
        {
            //Obtenção dos produtos do banco de dados através de uma DataTable
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PRODUTOS";
            DbDataReader reader = DAOUtils.GetDataReader(comando);
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        public static void Adicionar(Produto produto)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO PRODUTOS(DESCRICAO, PRECO, QUANTIDADE)" + 
                                  "VALUES (@descricao, @preco, @quantidade)";

            comando.Parameters.Add(DAOUtils.GetParametro("@descricao", produto.Descricao));
            comando.Parameters.Add(DAOUtils.GetParametro("@preco", produto.Preco));
            comando.Parameters.Add(DAOUtils.GetParametro("@quantidade", produto.Quantidade));
            comando.ExecuteNonQuery();
        }

        public static void Editar(Produto produto)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE PRODUTOS SET " +
                "DESCRICAO = @descricao, PRECO = @preco, QUANTIDADE = @quantidade WHERE ID = @id";

            comando.Parameters.Add(DAOUtils.GetParametro("@id", produto.Id));
            comando.Parameters.Add(DAOUtils.GetParametro("@descricao", produto.Descricao));
            comando.Parameters.Add(DAOUtils.GetParametro("@preco", produto.Preco));
            comando.Parameters.Add(DAOUtils.GetParametro("@quantidade", produto.Quantidade));
            comando.ExecuteNonQuery();
        }

        public static void Excluir(Produto produto)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM PRODUTOS WHERE ID = @id";

            comando.Parameters.Add(DAOUtils.GetParametro("@id", produto.Id));
            comando.ExecuteNonQuery();
        }

        public static void ImportarDeXML()
        {
            List<ProdutoXML> produtosXML = ProdutoXML.GetProdutos();
            foreach (ProdutoXML produtoAImportar in produtosXML)
            {
                Produto produtoConvertido = produtoAImportar.ToProduto();
                Adicionar(produtoConvertido);
            }
        }
    }
}
