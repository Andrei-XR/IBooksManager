using IBooksManagerLibrary.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Models
{
    public class Categoria : IEntity
    {
        public Categoria()
        {
            Livros = new List<Livro>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual List<Livro> Livros { get; set; }
    }
}
