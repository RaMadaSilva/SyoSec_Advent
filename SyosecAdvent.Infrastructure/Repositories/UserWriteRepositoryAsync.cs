using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public  class UserWriteRepositoryAsync :BaseWriteRepositoryAsync<User>, 
        IUserWriteRepositoryAsync
    {
        public UserWriteRepositoryAsync(SyosecAdventDbContext context) 
            : base(context)
        {
        }      
    }
}