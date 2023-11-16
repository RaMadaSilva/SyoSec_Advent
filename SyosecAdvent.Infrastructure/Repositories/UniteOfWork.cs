using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class UniteOfWork : IUnitOfWorkAsync
    {
        private readonly SyosecAdventDbContext _context;
        private IChurchReadRepositoryAsync _churchReadRepository;
        private IChurchWriteRepositoryAsync _churchWriteRepository;

        public UniteOfWork(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public IChurchReadRepositoryAsync ChurchReadRepository => throw new NotImplementedException();

        public IChurchWriteRepositoryAsync ChurchWriteRepository => throw new NotImplementedException();

        public IMemberReadRepositoryAsync MemberReadRepository => throw new NotImplementedException();

        public IMemberWriteRepositoryAsync MemberWriteRepository => throw new NotImplementedException();

        public IRecommendationReadRepositoryAsync RecommendationReadRepository => throw new NotImplementedException();

        public IRecommendationWriteRepositoryAsync RecommendationWriteRepository => throw new NotImplementedException();

        public IUserReadRepositoryAsync UserReadRepository => throw new NotImplementedException();

        public IUserWriteRepositoryAsync UserWriteRepository => throw new NotImplementedException();

        public IRoleReadRepositoryAsync RoleReadRepository => throw new NotImplementedException();

        public IRoleWriteRepositoryAsync RoleWriteRepository => throw new NotImplementedException();

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
          await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
