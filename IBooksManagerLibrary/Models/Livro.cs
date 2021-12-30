using IBooksManagerLibrary.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Models
{
    [Table("Livros")]
    public class Livro : IEntity
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public decimal Preco { get; set; }
        public int Paginas { get; set; }
        public int Quantidade { get; set; }
        public int Ano { get; set; }
        public int IdiomaId { get; set; }
        public int AutorId { get; set; }
        public int EditoraId { get; set; }

        public Autor Autor { get; set; }
        public Editora Editora {get;set;}
        public Idioma Idioma {get;set;}

    }
}
