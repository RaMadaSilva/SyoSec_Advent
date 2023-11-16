using Microsoft.EntityFrameworkCore;
using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class BaseReadRepositoryAsync<TEntity> 
        : IBaseReadRepositoryAsync<TEntity> where TEntity : Entity
    {
        private readonly SyosecAdventDbContext _context;
        private readonly DbSet<TEntity> _entities;

        public BaseReadRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
           return  await _entities.AsNoTracking().ToListAsync(); 
        }

        public  async Task<TEntity> GetByIdAsync(long id)
        {
           return await _entities.FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
