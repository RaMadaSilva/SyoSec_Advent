using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class RoleWriteRepositoryAsync : IRoleWriteRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public RoleWriteRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}