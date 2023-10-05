using SyoSec_Advent.Domain.Entities;

namespace SyoSec_Advent.Domain.Repositories
{
    public interface IUserReadRepository : IBaseReadRepository<User>
    {
        Task<IEnumerable<User>> GetAllUserWithRoleAsync();
        Task<User> GetAUserByIdWithRoleAsync(long id);
        Task<bool> AssociateUserAndRoles(long userId, IEnumerable<Role> roles);
    }
}
