using SyosecAdvent.Domain.Interfaces.Repositories;
using SyosecAdvent.Infrastructure.Data;

namespace SyosecAdvent.Infrastructure.Repositories
{
    public class UniteOfWork : IUnitOfWorkAsync
    {
        private readonly SyosecAdventDbContext _context;

        private IChurchReadRepositoryAsync _churchReadRepository;
        private IChurchWriteRepositoryAsync _churchWriteRepository;
        private IMemberReadRepositoryAsync _memberReadRepository;
        private IMemberWriteRepositoryAsync _memberWriteRepository; 
        private IRecommendationReadRepositoryAsync _recommendationReadRepository;
        private IRecommendationWriteRepositoryAsync _recommendationWriteRepository;
        private IUserReadRepositoryAsync _userReadRepository;
        private IUserWriteRepositoryAsync _userWriteRepository;
        private IRoleReadRepositoryAsync _roleReadRepository;
        private IRoleWriteRepositoryAsync _roleWriteRepository;

        public UniteOfWork(SyosecAdventDbContext context)
        {
            _context = context;
        }

        public IChurchReadRepositoryAsync ChurchReadRepository 
            => _churchReadRepository?? new ChurchReadRepositoryAsync(_context);

        public IChurchWriteRepositoryAsync ChurchWriteRepository 
            => _churchWriteRepository??new ChurchWriteRepositoryAsync(_context);

        public IMemberReadRepositoryAsync MemberReadRepository 
            => _memberReadRepository?? new MemberReadRepositoryAsync(_context);

        public IMemberWriteRepositoryAsync MemberWriteRepository 
            =>_memberWriteRepository??new MemberWriteRepositoryAsync(_context);

        public IRecommendationReadRepositoryAsync RecommendationReadRepository 
            => _recommendationReadRepository??new RecommendationReadRepositoryAsync(_context);

        public IRecommendationWriteRepositoryAsync RecommendationWriteRepository 
            => _recommendationWriteRepository??new RecommendationWriteRepositoryAsync(_context);

        public IUserReadRepositoryAsync UserReadRepository 
            => _userReadRepository?? new UserReadRepositoryAsync(_context);

        public IUserWriteRepositoryAsync UserWriteRepository 
            => _userWriteRepository?? new UserWriteRepositoryAsync(_context);

        public IRoleReadRepositoryAsync RoleReadRepository 
            => _roleReadRepository?? new RoleReadRepositoryAsync(_context);

        public IRoleWriteRepositoryAsync RoleWriteRepository
            => _roleWriteRepository ?? new RoleWriteRepositoryAsync(_context); 

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
          await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
