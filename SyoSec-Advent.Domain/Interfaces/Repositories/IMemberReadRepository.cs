using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.ValueObjects;

namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IMemberReadRepository : IBaseReadRepository<Member>
    {
        Task<Member> GetMemberByName(Name name);
    }
}
