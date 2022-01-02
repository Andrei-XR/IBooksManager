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

            Sql("INSERT INTO dbo.Categorias (Nome) VALUES ('ROMANCE');");

            AddColumn("dbo.Livros", "CategoriaId", c => c.Int(nullable: false, defaultValue: 1));
            AddForeignKey("dbo.Livros", "CategoriaId", "dbo.Categorias", "Id", cascadeDelete: true);
            CreateIndex("dbo.Livros", "CategoriaId");
            DropColumn("dbo.Livros", "Genero");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Livros", "Genero", c => c.String());
            DropForeignKey("dbo.Livros", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Livros", new[] { "CategoriaId" });
            DropColumn("dbo.Livros", "CategoriaId");
            DropTable("dbo.Categorias");
        }
    }
}
