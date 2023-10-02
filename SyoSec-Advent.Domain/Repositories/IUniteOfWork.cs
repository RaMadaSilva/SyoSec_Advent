namespace SyoSec_Advent.Domain.Repositories
{
    public interface IUniteOfWork
    {
        IChurchReadRepository ChurchReadRepository { get; }
        IChurchRepository ChurchRepository { get; }
        IMemberReadRepository MemberReadRepository { get; }
        IMemberRepository MemberRepository { get; }
        IRecommendationReadRepository RecommendationReadRepository { get; }
        IRecommendationRepository RecommendationRepository { get; }

        Task CommitAsync(CancellationToken cancellationToken = default); 
    }
}
