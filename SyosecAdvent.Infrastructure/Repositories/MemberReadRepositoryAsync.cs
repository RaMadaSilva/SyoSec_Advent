using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Domain.ValueObjects;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class MemberReadRepositoryAsync : BaseReadRepositoryAsync<Member>, 
        IMemberReadRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public MemberReadRepositoryAsync(SyosecAdventDbContext context) 
            : base(context)
        {
            _context = context;
        }

        public Task<Member> GetMemberByNameAsync(Name name)
        {
            throw new NotImplementedException();
        }
    }
}