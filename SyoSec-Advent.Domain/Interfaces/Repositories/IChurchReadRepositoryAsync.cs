using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IChurchReadRepositoryAsync : IBaseReadRepositoryAsync<Church>
    {
        Task<Church> GetChurchByNameAsync(string churcName); 
    }
}
