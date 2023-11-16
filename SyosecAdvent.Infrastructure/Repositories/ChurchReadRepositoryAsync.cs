using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class ChurchReadRepositoryAsync : IChurchReadRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public ChurchReadRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Church>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Church> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Church> GetChurchByNameAsync(string churcName)
        {
            throw new NotImplementedException();
        }
    }
}