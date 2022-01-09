using IBooksManagerLibrary.Data.Contracts;
using IBooksManagerLibrary.Models;
using RefactorThis.GraphDiff;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Data.Repositories
{
    public class LivroRepository : CrudRepository<Livro>, ILivroRepository
    {
        public override void Add(Livro entity)
        {
            foreach (var categoria in entity.Categorias)
            {
                _context.Entry(categoria).State = System.Data.Entity.EntityState.Unchanged;
            }

            base.Add(entity);
        }

        public override void Update(Livro entity)
        {
            _context.UpdateGraph(entity, map => map.AssociatedCollection(l => l.Categorias));
            base.Update(entity);
        }
    }
}
