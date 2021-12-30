using IBooksManagerLibrary.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Models
{
    [Table("Idiomas")]
    public class Idioma : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
