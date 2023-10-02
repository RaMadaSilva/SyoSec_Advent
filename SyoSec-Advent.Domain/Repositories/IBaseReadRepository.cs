using SyoSec_Advent.Domain.Entities;

namespace SyoSec_Advent.Domain.Repositories
{
    public interface IBaseReadRepository<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAllAsync ();
        Task<TEntity> GetByIdAsync(Guid id);
    }
}
