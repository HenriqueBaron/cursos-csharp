using Aula_16_SegundoExercicio.Dominio;
using Aula_16_SegundoExercicio.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_SegundoExercicio.Repositorio
{
    public class RepositorioProduto : IRepositorioGenerico<Produto>
    {
        public void Atualizar(Produto entidade)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                db.Produtos.Attach(entidade);
                db.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Excluir(Produto entidade)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                db.Produtos.Attach(entidade);
                db.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Produto GetById(int id)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                return db.Produtos.Find(id);
            }
        }

        public List<Produto> GetDados()
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                return db.Produtos.ToList();
            }
        }

        public void Inserir(Produto entidade)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                db.Produtos.Add(entidade);
                db.SaveChanges();
            }
        }
    }
}
