using IBooksManagerLibrary.Data.Contracts;
using IBooksManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Data.Repositories
{
    public class AutorRepository : CrudRepository<Autor>, IAutorRepository
    {
        public bool ValidarRemocao(int id)
        {
            bool semRelacaoComLivros = !_context.Livros.Any(l => l.AutorId == id);
            return semRelacaoComLivros;
        }
    }
}
