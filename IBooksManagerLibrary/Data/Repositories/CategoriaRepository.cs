using IBooksManagerLibrary.Data.Contracts;
using IBooksManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Data.Repositories
{
    public class CategoriaRepository : CrudRepository<Categoria>, ICategoriaRepository
    {
        public bool ValidarRemocao(int id)
        {
            bool semRelacaoComLivros = !_context.Livros.Any(l => l.CategoriaId == id);
            return semRelacaoComLivros;
        }
    }
}
