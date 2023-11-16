using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class RecommendationReadRepositoryAsync : BaseReadRepositoryAsync<Recommendation>,
        IRecommendationReadRepositoryAsync
    {
        public RecommendationReadRepositoryAsync(SyosecAdventDbContext context) 
            : base(context)
        {
        }
    }
}