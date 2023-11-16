using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class ChurchWriteRepositoryAsync : IChurchWriteRepositoryAsync
    {
        private readonly SyosecAdventDbContext  _context;

        public ChurchWriteRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context; 
        }

        public Task AddAsync(Church entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Church entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Church entity)
        {
            throw new NotImplementedException();
        }
    }
}