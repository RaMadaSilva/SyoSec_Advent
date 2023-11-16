using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class RecommendationWriteRepositoryAsync : BaseWriteRepositoryAsync<Recommendation>, 
        IRecommendationWriteRepositoryAsync
    {
        public RecommendationWriteRepositoryAsync(SyosecAdventDbContext context)
            : base(context)
        {
        }
    }
}