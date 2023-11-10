using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IBaseReadRepositoryAsync<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(long id);
    }
}
