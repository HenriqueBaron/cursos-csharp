using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.ProdutosMarcas.Dominio;
using TreinaWeb.ProdutosMarcas.Persist.EF.Context;
using TreinaWeb.Repositorio.Comum;

namespace TreinaWeb.ProdutosMarcas.Repos.EF
{
    public class RepositorioProduto : IRepositorioGenerico<Produto>
    {
        public Task<List<Produto>> SelecionarTodos()
        {
            return Task.Run(() =>
            {
                using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
                {
                    return contexto.Produtos.Include("Marca").ToList();
                }
            });
        }

        public Produto SelecionarPorId(int id)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                return contexto.Produtos.Include("Marca").Single(s => s.Id == id);
            }
        }

        public void Inserir(Produto entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                Marca marca = contexto.Marcas.Find(entidade.MarcaId);
                entidade.Marca = marca;
                contexto.Produtos.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public void Atualizar(Produto entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                Marca marca = contexto.Marcas.Find(entidade.MarcaId);
                entidade.Marca = marca;
                contexto.Produtos.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Produto entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Produtos.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}
