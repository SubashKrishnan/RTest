using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly dbdevdgitoolContext context;
        private readonly DbSet<T> entity;
        public Repository(dbdevdgitoolContext context)
        {
            this.context = context;
            entity = context.Set<T>();
        }
        
        public virtual async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = entity;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }
    }
}
