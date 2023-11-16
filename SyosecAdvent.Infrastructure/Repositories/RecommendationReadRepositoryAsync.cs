using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class RecommendationReadRepositoryAsync : IRecommendationReadRepositoryAsync
    {
        private readonly SyosecAdventDbContext _dbContext;

        public RecommendationReadRepositoryAsync(SyosecAdventDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<IEnumerable<Recommendation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Recommendation> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}