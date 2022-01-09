using IBooksManagerLibrary.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using RefactorThis.GraphDiff;

namespace IBooksManagerLibrary.Data.Repositories
{
    public abstract class CrudRepository<T> where T : class, new()
    {
        protected readonly DbIBooksContext _context = new DbIBooksContext();

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public virtual bool Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public virtual T Get(Expression<Func<T, bool>> expression, params string[] includes)
        {
            return _context.Set<T>().AsNoTracking()
                .Where(expression)
                .IncludeMany(includes)
                .SingleOrDefault();
        }

        public virtual List<T> List(string[] includes = null)
        {
            var query = _context.Set<T>().AsNoTracking().IncludeMany(includes);
            return query.ToList();
        }

        public virtual void Update(T entity)
        {
            _context.UpdateGraph(entity);
            _context.SaveChanges();
        }
    }
}
