using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> filter = null);
    }
}
