namespace TreinaWeb.CSAvEx162.Persist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao_Produto_Venda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemVendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Double(nullable: false),
                        VendaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.ProdutoId)
                .ForeignKey("dbo.Vendas", t => t.VendaId)
                .Index(t => t.ProdutoId)
                .Index(t => t.VendaId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemVendas", "VendaId", "dbo.Vendas");
            DropForeignKey("dbo.ItemVendas", "ProdutoId", "dbo.Produtoes");
            DropIndex("dbo.ItemVendas", new[] { "VendaId" });
            DropIndex("dbo.ItemVendas", new[] { "ProdutoId" });
            DropTable("dbo.Vendas");
            DropTable("dbo.Produtoes");
            DropTable("dbo.ItemVendas");
        }
    }
}
