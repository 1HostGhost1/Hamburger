using Hamburger_Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Core.Service
{
    public interface ICoreService<T> where T : CoreEntity
    {
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }
        Task<T> Add(T item);
        Task<T> Update(T item);
        Task<bool> Remove(int id);
        Task<bool> Remove(T item);
        IQueryable<T> GetActives();
        Task<T> GetById(int id, params Expression<Func<T, object>>[] includeParameters);
        Task<T> GetByDefault(Expression<Func<T, bool>> exp, params Expression<Func<T, object>>[] includeParameters);
        IQueryable<T> GetDefault(Expression<Func<T, bool>> exp, params Expression<Func<T, object>>[] includeParameters);
        Task<bool> Activate(int id);
        Task<bool> Any(Expression<Func<T, bool>> exp);
        Task<int> Save();
    }
}