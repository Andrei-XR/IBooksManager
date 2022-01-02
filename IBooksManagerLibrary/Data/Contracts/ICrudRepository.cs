using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Data.Contracts
{
    public interface ICrudRepository<TEntity>
    {
        void Add(TEntity entity);
        bool Delete(int id);
        void Update(TEntity entity);
        List<TEntity> List(string[] includes = null);
        TEntity Get(Expression<Func<TEntity, bool>> expression, string[] includes = null);
    }
}
