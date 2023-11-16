using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class ChurchReadRepositoryAsync :BaseReadRepositoryAsync<Church>, IChurchReadRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public ChurchReadRepositoryAsync(SyosecAdventDbContext context) 
            : base(context)
        {
           //_context = context;
        }

        public async Task<Church> GetChurchByNameAsync(string churcName)
        {
            
            throw new NotImplementedException();
        }
    }
}