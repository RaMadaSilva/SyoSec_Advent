using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class RecommendationWriteRepositoryAsync : IRecommendationWriteRepositoryAsync
    {
        private readonly SyosecAdventDbContext _context;

        public RecommendationWriteRepositoryAsync(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Recommendation entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Recommendation entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Recommendation entity)
        {
            throw new NotImplementedException();
        }
    }
}