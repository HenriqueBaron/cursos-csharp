namespace Aula_16_SegundoExercicio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Inicial_Criacao_Banco_Mercado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PedidoDetalhes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Double(nullable: false),
                        Desconto = c.Double(nullable: false),
                        Pedido_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_Id, true)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .Index(t => t.Pedido_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataVenda = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PedidoDetalhes", "Produto_Id", "dbo.Produtoes");
            DropForeignKey("dbo.PedidoDetalhes", "Pedido_Id", "dbo.Pedidoes");
            DropIndex("dbo.PedidoDetalhes", new[] { "Produto_Id" });
            DropIndex("dbo.PedidoDetalhes", new[] { "Pedido_Id" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.PedidoDetalhes");
        }
    }
}
