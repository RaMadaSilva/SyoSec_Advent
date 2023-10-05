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
        IUserReadRepository UserReadRepository { get; }
        IUserWriteRepository UserWriteRepository { get; }
        IRoleReadRepository RoleReadRepository { get; }
        IRoleWriteRepository RoleWriteRepository { get; }

        Task CommitAsync(CancellationToken cancellationToken = default); 
    }
}
