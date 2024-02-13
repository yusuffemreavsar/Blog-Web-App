using Core.Entities;
using Data.Context;
using Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntityBase,new()
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext appDbContext)
        {
            _context= appDbContext;
        }

        private DbSet<TEntity> Table { get => _context.Set<TEntity>(); }

        public async Task AddAsync(TEntity entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate= null ,params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = Table;
            if(predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query= Table;    
            query=query.Where(predicate);
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.SingleAsync();
        }

        public async Task<TEntity> GetByGuidAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await Table.CountAsync(predicate);
        }
    }
}
