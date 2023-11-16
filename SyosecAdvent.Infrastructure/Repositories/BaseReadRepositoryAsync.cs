using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class BaseReadRepositoryAsync<TEntity> : IBaseReadRepositoryAsync<TEntity> where TEntity : Entity
    {
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public  async Task<TEntity> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
