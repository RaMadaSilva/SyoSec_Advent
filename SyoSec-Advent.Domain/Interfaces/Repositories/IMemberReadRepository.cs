using SyoSec_Advent.Domain.Entities;
using SyoSec_Advent.Domain.ValueObject;

namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IMemberReadRepository : IBaseReadRepository<Member>
    {
        Task<Member> GetMemberByName(Name name);
    }
}
