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
    public class RepositorioProduto : IRepositorio<Produto>
    {
        public Task<List<Produto>> SelecionarTodos()
        {
            return Task.Run(() =>
            {
                using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
                {
                    return contexto.Produtos.ToList();
                }
            });
        }

        public Produto SelecionarPorId(int id)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                return contexto.Produtos.Find(id);
            }
        }

        public void Inserir(Produto entidade)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                contexto.Produtos.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public void Atualizar(Produto entidade)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                contexto.Produtos.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Produto entidade)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                contexto.Produtos.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}
