﻿using IBooksManagerLibrary.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace IBooksManagerLibrary.Data.Repositories
{
    public abstract class CrudRepository<T> : ICrudRepository<T> where T : class
    {
        protected DbIBooksContext _context = new DbIBooksContext();

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
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
            var query = _context.Set<T>().AsNoTracking();
            var querier = query.IncludeMany(includes);

            return querier.ToList();
        }

        public virtual void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
