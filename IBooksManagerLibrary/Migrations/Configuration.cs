namespace IBooksManagerLibrary.Migrations
{
    using IBooksManagerLibrary.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IBooksManagerLibrary.Data.DbIBooksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IBooksManagerLibrary.Data.DbIBooksContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            if (!context.Autores.Any())
            {
                context.Autores.Add(new Autor { Nome = "Machado de Assis" });
                context.SaveChanges();
            }

            if (!context.Editoras.Any())
            {
                context.Editoras.Add(new Editora { Nome = "Brasil" });
                context.SaveChanges();
            }

            if (!context.Idiomas.Any())
            {
                context.Idiomas.Add(new Idioma { Nome = "Portugues-Br" });
                context.SaveChanges();
            }

            if (!context.Categorias.Any())
            {
                context.Categorias.Add(new Categoria { Nome = "Romance" });
                context.SaveChanges();
            }
        }
    }
}
