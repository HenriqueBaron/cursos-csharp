using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.CSAvEx162.Dominio;
using TreinaWeb.CSAvEx162.Persist;
using TreinaWeb.CSAvEx162.Repos.Comum;

namespace TreinaWeb.CSAvEx162.Repos.EF
{
    public class RepositorioItemVenda : IRepositorio<ItemVenda>
    {
        public Task<List<ItemVenda>> SelecionarTodos()
        {
            return Task.Run(() =>
            {
                using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
                {
                    return contexto.ItensVendas.Include("Produto").Include("Venda").ToList();
                }
            });
        }

        public ItemVenda SelecionarPorId(int id)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                return contexto.ItensVendas.Include("Produto").Include("Venda").Single(s => s.Id == id);
            }
        }

        public void Inserir(ItemVenda entidade)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                Produto produto = contexto.Produtos.Find(entidade.ProdutoId);
                Venda venda = contexto.Vendas.Find(entidade.VendaId);
                entidade.Produto = produto;
                entidade.Venda = venda;
                contexto.ItensVendas.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public void Atualizar(ItemVenda entidade)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                Produto produto = contexto.Produtos.Find(entidade.ProdutoId);
                Venda venda = contexto.Vendas.Find(entidade.VendaId);
                entidade.Produto = produto;
                entidade.Venda = venda;
                contexto.ItensVendas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(ItemVenda entidade)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                contexto.ItensVendas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}
