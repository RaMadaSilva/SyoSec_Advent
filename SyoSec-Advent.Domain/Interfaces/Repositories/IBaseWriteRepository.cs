using SyoSec_Advent.Domain.Entities;

namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IBaseWriteRepository<TEntity> where TEntity : Entity
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
