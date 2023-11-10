using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.ValueObjects;

namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IMemberReadRepositoryAsync : IBaseReadRepositoryAsync<Member>
    {
        Task<Member> GetMemberByNameAsync(Name name);
    }
}
