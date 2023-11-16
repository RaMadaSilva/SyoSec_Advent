using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class BaseReadRepositoryAsync<TEntity> 
        : IBaseReadRepositoryAsync<TEntity> where TEntity : Entity
    {
        private readonly SyosecAdventDbContext _context;

        public BaseReadRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

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
