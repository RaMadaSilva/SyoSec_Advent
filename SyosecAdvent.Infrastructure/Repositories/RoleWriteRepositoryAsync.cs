using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class RoleWriteRepositoryAsync :BaseWriteRepositoryAsync<Role>, 
        IRoleWriteRepositoryAsync
    {
        public RoleWriteRepositoryAsync(SyosecAdventDbContext context) 
            : base(context)
        {
        }

    }
}