using Hamburger_Core.Entity;
using Hamburger_Core.Service;
using Hamburger_Model.Context;
using Hamburger_Service.Service.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.Service.Base
{
    public class BaseService<T> : ICoreService<T> where T : CoreEntity
    {
        internal readonly DataContext _db;

        public BaseService()
        {
            _db = Tools.DbInstance;
        }

        private DbSet<T> _entities;

        public DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _db.Set<T>();
                return _entities;
            }
        }
        public IQueryable<T> Table
        {
            get
            {
                return Entities;
            }
        }

        public IQueryable<T> TableNoTracking
        {
            get
            {
                return Entities.AsNoTracking();
            }
        }

        public async Task<T> Add(T item)
        {
            try
            {
                if (item == null)
                    return null;

                Entities.Add(item);

                if (await Save() > 0)
                    return item;
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<T> Update(T item)
        {
            Entities.Attach(item);
            _db.Entry(item).State = EntityState.Modified;

            if (await Save() > 0)
                return item;
            else
                return null;
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                T item = await GetById(id);
                item.Status = Status.Deleted;
                if (await Update(item) != null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> Remove(T item)
        {
            item.Status = Status.Deleted;
            if (await Update(item) != null)
                return true;
            else
                return false;
        }

        public async Task<bool> Any(Expression<Func<T, bool>> exp) => await Entities.AnyAsync(exp);

        public IQueryable<T> GetActives() => Entities.Where(x => x.Status == Status.Active).AsQueryable();

        public async Task<T> GetByDefault(Expression<Func<T, bool>> exp, params Expression<Func<T, object>>[] includeParameters)
        {
            IQueryable<T> queryable = TableNoTracking;
            foreach (Expression<Func<T, object>> includeParameter in includeParameters)
                queryable = queryable.Include(includeParameter);
            return await queryable.FirstOrDefaultAsync(exp);
        }

        public async Task<T> GetById(int id, params Expression<Func<T, object>>[] includeParameters)
        {
            IQueryable<T> queryable = TableNoTracking;
            foreach (Expression<Func<T, object>> includeParameter in includeParameters)
                queryable = queryable.Include(includeParameter);
            return await queryable.FirstOrDefaultAsync(x => x.Id == id);
        }

        public IQueryable<T> GetDefault(Expression<Func<T, bool>> exp, params Expression<Func<T, object>>[] includeParameters)
        {
            IQueryable<T> queryable = TableNoTracking;
            foreach (Expression<Func<T, object>> includeParameter in includeParameters)
                queryable = queryable.Include(includeParameter);
            return queryable.Where(exp).AsQueryable();
        }

        public async Task<bool> Activate(int id)
        {
            T activated = await GetById(id);
            activated.Status = Status.Active;
            if (await Update(activated) != null)
                return true;
            else
                return false;
        }

        public async Task<int> Save()
        {
            return await _db.SaveChangesAsync();
        }
    }
}
