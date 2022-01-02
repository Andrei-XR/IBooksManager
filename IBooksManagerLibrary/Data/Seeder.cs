using IBooksManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Data
{
    public static class Seeder
    {
        private static readonly DbIBooksContext context = new DbIBooksContext();

        public static void Run()
        {
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

            context.Dispose();
        }
    }
}
