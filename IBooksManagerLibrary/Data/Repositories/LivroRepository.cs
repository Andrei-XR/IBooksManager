using IBooksManagerLibrary.Data.Contracts;
using IBooksManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Data.Repositories
{
    public class LivroRepository : CrudRepository<Livro>, ILivroRepository
    {
    }
}
