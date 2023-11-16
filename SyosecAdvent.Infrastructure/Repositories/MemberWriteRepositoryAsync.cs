using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class MemberWriteRepositoryAsync : BaseWriteRepositoryAsync<Member>,  
        IMemberWriteRepositoryAsync
    {
        public MemberWriteRepositoryAsync(SyosecAdventDbContext context)
            : base(context)
        {
        }
    }
}