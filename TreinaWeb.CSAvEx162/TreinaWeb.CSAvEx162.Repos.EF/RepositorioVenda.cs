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
    public class RepositorioVenda : IRepositorio<Venda>
    {
        public Task<List<Venda>> SelecionarTodos()
        {
            return Task.Run(() =>
            {
                using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
                {
                    return contexto.Vendas.ToList();
                }
            });
        }

        public Venda SelecionarPorId(int id)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                return contexto.Vendas.Find(id);
            }
        }

        public void Inserir(Venda entidade)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                contexto.Vendas.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public void Atualizar(Venda entidade)
        {
            using(ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                contexto.Vendas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Venda entidade)
        {
            using (ProdutosVendasDbContext contexto = new ProdutosVendasDbContext())
            {
                contexto.Vendas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}
