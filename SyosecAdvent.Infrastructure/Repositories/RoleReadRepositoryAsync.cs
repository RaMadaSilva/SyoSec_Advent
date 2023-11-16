using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public  class RoleReadRepositoryAsync : IRoleReadRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public RoleReadRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Role>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}