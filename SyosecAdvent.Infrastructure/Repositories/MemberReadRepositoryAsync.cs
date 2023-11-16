using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Domain.ValueObjects;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class MemberReadRepositoryAsync : IMemberReadRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public MemberReadRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Member>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Member> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Member> GetMemberByNameAsync(Name name)
        {
            throw new NotImplementedException();
        }
    }
}