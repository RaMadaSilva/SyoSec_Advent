using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class UserReadRepositoryAsync : IUserReadRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public UserReadRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public Task<bool> AssociateUserAndRoles(long userId, IEnumerable<Role> roles)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUserWithRoleAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAUserByIdWithRoleAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}