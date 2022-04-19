using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Store.Models.IRepository;
using Store.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Store.Presistance.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly StoreContext _context;
        readonly DbSet<T> entity;

        public BaseRepository(StoreContext storeContext)
        {
            _context = storeContext;
            entity = _context.Set<T>();
        }
        public ValueTask<EntityEntry<T>> AddAsync(T t)
        {
            return _context.Set<T>().AddAsync(t);
        }

        public ValueTask<T> GetByIdAsync(int id)
        {
            return _context.Set<T>().FindAsync(id);
        }
        public Task AddRangeAsync(IEnumerable<T> entities)
        {
            return _context.Set<T>().AddRangeAsync(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return entity.Where(expression);
        }
        public Task<List<T>> GetAllAsync()
        {
            return _context.Set<T>().AsNoTracking().ToListAsync();
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
