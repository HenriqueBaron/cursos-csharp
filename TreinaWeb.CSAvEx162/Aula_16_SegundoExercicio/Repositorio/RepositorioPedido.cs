using Aula_16_SegundoExercicio.Dominio;
using Aula_16_SegundoExercicio.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_SegundoExercicio.Repositorio
{
    public class RepositorioPedido : IRepositorioGenerico<Pedido>
    {
        public void Atualizar(Pedido entidade)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                var pedido = db.Pedidos.Find(entidade.Id);
                pedido.DataVenda = entidade.DataVenda;
                db.SaveChanges();
            }
        }

        public void Excluir(Pedido entidade)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                var pedido = db.Pedidos.Find(entidade.Id);
                db.Pedidos.Remove(pedido);
                db.SaveChanges();
            }
        }

        public Pedido GetById(int id)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                return db.Pedidos.Include("Detalhes").Include("Detalhes.Produto").FirstOrDefault(p => p.Id == id);
            }
        }

        public List<Pedido> GetDados()
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                return db.Pedidos.Include("Detalhes").Include("Detalhes.Produto").ToList();
            }
        }

        public void Inserir(Pedido entidade)
        {
            using (MercadoDbContext db = new MercadoDbContext())
            {
                foreach(var detalhe in entidade.Detalhes)
                    detalhe.Produto = db.Produtos.Find(detalhe.Produto.Id);

                db.Pedidos.Add(entidade);
                db.SaveChanges();
            }
        }
    }
}
