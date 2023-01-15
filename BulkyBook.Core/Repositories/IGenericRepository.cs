using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        T GetFirstOrDefault(Expression<Func<T, bool>> expression, string? includeProperties = null);
        void Add(T entity);
        void AddRange(IEnumerable<T> entites);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
