namespace SyoSec_Advent.Domain.Repositories
{
    public interface IUniteOfWork
    {
        IChurchReadRepository ChurchReadRepository { get; }
        IChurchWriteRepository ChurchWriteRepository { get; }
        IMemberReadRepository MemberReadRepository { get; }
        IMemberWriteRepository MemberWriteRepository { get; }
        IRecommendationReadRepository RecommendationReadRepository { get; }
        IRecommendationWriteRepository RecommendationWriteRepository { get; }

        Task CommitAsync(CancellationToken cancellationToken = default); 
    }
}
