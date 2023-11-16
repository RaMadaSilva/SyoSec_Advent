using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public  class UserWriteRepositoryAsync : IUserWriteRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public UserWriteRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}