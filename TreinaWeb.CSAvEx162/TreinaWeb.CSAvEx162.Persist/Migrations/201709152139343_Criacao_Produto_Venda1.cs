namespace TreinaWeb.CSAvEx162.Persist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao_Produto_Venda1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemVendas", "VendaId", "dbo.Vendas");
            AddForeignKey("dbo.ItemVendas", "VendaId", "dbo.Vendas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemVendas", "VendaId", "dbo.Vendas");
            AddForeignKey("dbo.ItemVendas", "VendaId", "dbo.Vendas", "Id");
        }
    }
}
