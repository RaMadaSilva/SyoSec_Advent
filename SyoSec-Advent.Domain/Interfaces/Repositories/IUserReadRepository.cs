using SyoSec_Advent.Domain.Entities;

namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IUserReadRepository : IBaseReadRepository<User>
    {
        Task<IEnumerable<User>> GetAllUserWithRoleAsync();
        Task<User> GetAUserByIdWithRoleAsync(long id);
        Task<bool> AssociateUserAndRoles(long userId, IEnumerable<Role> roles);
    }
}
