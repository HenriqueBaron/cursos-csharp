using Aula_16_SegundoExercicio.Dominio;
using Aula_16_SegundoExercicio.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_SegundoExercicio.Repositorio
{
    public class RepositorioPedidoDetalhe : IRepositorioGenerico<PedidoDetalhe>
    {
        public void Atualizar(PedidoDetalhe entidade)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                db.PedidoDetalhes.Attach(entidade);
                db.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Excluir(PedidoDetalhe entidade)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                db.PedidoDetalhes.Attach(entidade);
                db.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public PedidoDetalhe GetById(int id)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                return db.PedidoDetalhes.Include("Pedido").Include("Produtos").FirstOrDefault(p => p.Id == id);
            }
        }

        public List<PedidoDetalhe> GetDados()
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                return db.PedidoDetalhes.Include("Pedido").Include("Produtos").ToList();
            }
        }

        public void Inserir(PedidoDetalhe entidade)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                entidade.Produto = db.Produtos.Find(entidade.Produto.Id);

                entidade.Pedido = db.Pedidos.Find(entidade.Pedido.Id);

                db.PedidoDetalhes.Add(entidade);
                db.SaveChanges();
            }
        }
    }
}
