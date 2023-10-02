using SyoSec_Advent.Domain.Entities;
using SyoSec_Advent.Domain.ValueObject;

namespace SyoSec_Advent.Domain.Repositories
{
    public interface IMemberReadRepository: IBaseReadRepository<Member>
    {
        Task<Member> GetMemberByName(Name name); 
    }
}
