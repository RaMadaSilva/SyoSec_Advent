namespace SyosecAdvent.Domain.Interfaces.Repositories
{
    public interface IUnitOfWorkAsync
    {
        IChurchReadRepositoryAsync ChurchReadRepository { get; }
        IChurchWriteRepositoryAsync ChurchWriteRepository { get; }
        IMemberReadRepositoryAsync MemberReadRepository { get; }
        IMemberWriteRepositoryAsync MemberWriteRepository { get; }
        IRecommendationReadRepositoryAsync RecommendationReadRepository { get; }
        IRecommendationWriteRepositoryAsync RecommendationWriteRepository { get; }
        IUserReadRepositoryAsync UserReadRepository { get; }
        IUserWriteRepositoryAsync UserWriteRepository { get; }
        IRoleReadRepositoryAsync RoleReadRepository { get; }
        IRoleWriteRepositoryAsync RoleWriteRepository { get; }

        Task CommitAsync(CancellationToken cancellationToken = default);
    }
}
