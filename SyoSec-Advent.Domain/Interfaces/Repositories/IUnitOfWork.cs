namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
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
