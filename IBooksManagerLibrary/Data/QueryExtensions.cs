using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IBooksManagerLibrary.Data
{
    public static class QueryExtensions
    {
        public static IQueryable<T> IncludeMany<T>(this IQueryable<T> query, params string[] includes)
        {
            if(includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return query;
        }
    }
}
