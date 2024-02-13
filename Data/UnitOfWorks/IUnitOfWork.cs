using Core.Entities;
using Data.Repositories.Abstract;

namespace Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity: class,IEntityBase,new();

        Task<int> SaveAsync();
        int Save();
    }
}
