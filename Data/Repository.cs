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
        private readonly DbSet<T> entities;
        public Repository(dbdevdgitoolContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        
        public virtual async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = entities;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public virtual async Task<T> GetByID(object id)
        {
            return await entities.FindAsync(id);
        }

        public virtual void Insert(T entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public virtual void Delete(object id)
        {
            T entityToDelete = entities.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                entities.Attach(entityToDelete);
            }
            entities.Remove(entityToDelete);
            context.SaveChanges();
        }

        public virtual void Update(T entityToUpdate)
        {
            entities.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
