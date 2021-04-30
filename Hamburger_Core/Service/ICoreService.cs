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
        List<T> GetActives();
        List<T> GetDefault(Expression<Func<T, bool>> predicate);
        T GetByDefault(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        T Add(T item);
        T Update(T item);
        T Remove(int id);
        T Remove(T item);
    }
}