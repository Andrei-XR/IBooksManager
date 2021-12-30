namespace IBooksManagerLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Genero = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paginas = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Ano = c.Int(nullable: false),
                        IdiomaId = c.Int(nullable: false),
                        AutorId = c.Int(nullable: false),
                        EditoraId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Autores", t => t.AutorId, cascadeDelete: true)
                .ForeignKey("dbo.Editoras", t => t.EditoraId, cascadeDelete: true)
                .ForeignKey("dbo.Idiomas", t => t.IdiomaId, cascadeDelete: true)
                .Index(t => t.IdiomaId)
                .Index(t => t.AutorId)
                .Index(t => t.EditoraId);
            
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Idiomas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livros", "IdiomaId", "dbo.Idiomas");
            DropForeignKey("dbo.Livros", "EditoraId", "dbo.Editoras");
            DropForeignKey("dbo.Livros", "AutorId", "dbo.Autores");
            DropIndex("dbo.Livros", new[] { "EditoraId" });
            DropIndex("dbo.Livros", new[] { "AutorId" });
            DropIndex("dbo.Livros", new[] { "IdiomaId" });
            DropTable("dbo.Idiomas");
            DropTable("dbo.Editoras");
            DropTable("dbo.Livros");
            DropTable("dbo.Autores");
        }
    }
}
