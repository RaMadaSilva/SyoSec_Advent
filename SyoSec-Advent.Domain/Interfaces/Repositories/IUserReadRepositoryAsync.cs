using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IUserReadRepositoryAsync : IBaseReadRepositoryAsync<User>
    {
        Task<IEnumerable<User>> GetAllUserWithRoleAsync();
        Task<User> GetAUserByIdWithRoleAsync(long id);
        Task<bool> AssociateUserAndRoles(long userId, IEnumerable<Role> roles);
    }
}
