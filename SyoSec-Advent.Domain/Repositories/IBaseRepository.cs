using SyoSec_Advent.Domain.Entities;

namespace SyoSec_Advent.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : Entity
    {
        Task AddAsync (TEntity entity);
        Task UpdateAsync (TEntity entity);
        Task DeleteAsync (TEntity entity);
    }
}
