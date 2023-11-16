using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public  class RoleReadRepositoryAsync : BaseReadRepositoryAsync<Role>, 
        IRoleReadRepositoryAsync
    {
        public RoleReadRepositoryAsync(SyosecAdventDbContext context)
            : base(context)
        {
           
        }
    }
}