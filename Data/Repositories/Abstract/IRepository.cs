using Core.Entities;
using System.Linq.Expressions;

namespace Data.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : class, IEntityBase, new()
    {
        public Task AddAsync(TEntity entity);
        public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);
        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
        public Task<TEntity> GetByGuidAsync(Guid id);
        public Task<TEntity> UpdateAsync(TEntity entity);
        public Task DeleteAsync(TEntity entity);
        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null);

    }
}
