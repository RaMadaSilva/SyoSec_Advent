using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IBaseWriteRepositoryAsync<TEntity> where TEntity : Entity
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
