using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class BaseWriteRepositoryAsync<TEntity> : IBaseWriteRepositoryAsync<TEntity> where TEntity : Entity
    {
        public async Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
