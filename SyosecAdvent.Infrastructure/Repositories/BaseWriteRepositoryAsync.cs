using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class BaseWriteRepositoryAsync<TEntity> :
        IBaseWriteRepositoryAsync<TEntity> where TEntity : Entity
    {
        private readonly SyosecAdventDbContext _context;

        public BaseWriteRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

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
