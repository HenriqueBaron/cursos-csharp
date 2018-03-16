using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.CSAvEx162.Dominio;

namespace TreinaWeb.CSAvEx162.Persist
{
    public class ProdutosVendasDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItensVendas { get; set; }

        public ProdutosVendasDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemVenda>()
                .HasRequired(item => item.Venda)
                .WithMany(v => v.Itens)
                .HasForeignKey(fk => fk.VendaId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ItemVenda>()
                .HasRequired(item => item.Produto)
                .WithMany(p => p.Vendas)
                .HasForeignKey(fk => fk.ProdutoId)
                .WillCascadeOnDelete(false);
        }
    }
}
