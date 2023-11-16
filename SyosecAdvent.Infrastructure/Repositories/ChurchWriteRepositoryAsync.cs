using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class ChurchWriteRepositoryAsync : BaseWriteRepositoryAsync<Church>, 
        IChurchWriteRepositoryAsync
    {
        public ChurchWriteRepositoryAsync(SyosecAdventDbContext context) 
            : base(context)
        {
        }
    }
}