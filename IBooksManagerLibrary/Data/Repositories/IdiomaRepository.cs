using IBooksManagerLibrary.Data.Contracts;
using IBooksManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Data.Repositories
{
    public class IdiomaRepository : CrudRepository<Idioma>, IIdiomaRepository
    {
        public bool ValidarRemocao(int id)
        {
            bool semRelacaoComLivros = !_context.Livros.Any(l => l.IdiomaId == id);
            return semRelacaoComLivros;
        }
    }
}
