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
    public class RepositorioMarca : IRepositorioGenerico<Marca>
    {
        public Task<List<Marca>> SelecionarTodos()
        {
            return Task.Run(() =>
            {
                using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
                {
                    return contexto.Marcas.ToList();
                }
            });
        }

        public Marca SelecionarPorId(int id)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                return contexto.Marcas.Find(id);
            }
        }

        public void Inserir(Marca entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Marcas.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public void Atualizar(Marca entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Marcas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Marca entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Marcas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}
