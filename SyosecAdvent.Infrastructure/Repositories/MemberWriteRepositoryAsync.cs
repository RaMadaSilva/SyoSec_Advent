using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class MemberWriteRepositoryAsync : IMemberWriteRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public MemberWriteRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Member entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Member entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Member entity)
        {
            throw new NotImplementedException();
        }
    }
}