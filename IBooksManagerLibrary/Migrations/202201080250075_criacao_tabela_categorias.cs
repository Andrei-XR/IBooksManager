namespace IBooksManagerLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criacao_tabela_categorias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LivroCategorias",
                c => new
                    {
                        Livro_Id = c.Int(nullable: false),
                        Categoria_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Livro_Id, t.Categoria_Id })
                .ForeignKey("dbo.Livros", t => t.Livro_Id, cascadeDelete: true)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id, cascadeDelete: true)
                .Index(t => t.Livro_Id)
                .Index(t => t.Categoria_Id);
            
            DropColumn("dbo.Livros", "Genero");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Livros", "Genero", c => c.String());
            DropForeignKey("dbo.LivroCategorias", "Categoria_Id", "dbo.Categorias");
            DropForeignKey("dbo.LivroCategorias", "Livro_Id", "dbo.Livros");
            DropIndex("dbo.LivroCategorias", new[] { "Categoria_Id" });
            DropIndex("dbo.LivroCategorias", new[] { "Livro_Id" });
            DropTable("dbo.LivroCategorias");
            DropTable("dbo.Categorias");
        }
    }
}
