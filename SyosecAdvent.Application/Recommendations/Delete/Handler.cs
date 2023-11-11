using MediatR;
using SyosecAdvent.Application.Common;
using SyosecAdvent.Domain.Interfaces.Repositories;

namespace SyosecAdvent.Application.Recommendations.Delete
{
    public class Handler : IRequestHandler<Request, DeleteResponse>
    {
        private readonly IUnitOfWorkAsync _Uow;

        public Handler(IUnitOfWorkAsync uow)
        {
            _Uow = uow;
        }

        public async Task<DeleteResponse> Handle(Request request, CancellationToken cancellationToken)
        {
            try
            {
                var recommendation = await _Uow.RecommendationReadRepository.GetByIdAsync(request.Id);
                if (recommendation is null)
                    return new DeleteResponse("Não exite recomendacao com esse Id", 404);
               await _Uow.RecommendationWriteRepository.DeleteAsync(recommendation);
                await _Uow.CommitAsync(cancellationToken);

                var data = new DataRecommendationResponse(recommendation.Id,
                    recommendation.Member.NameMember.ToString(),
                    recommendation.Church.ToString(),
                    Enum.GetName(recommendation.RecommendationType));

                return new DeleteResponse("Recomendação removida com sucesso!", data); 

            }catch (Exception ex)
            {
                return new DeleteResponse(ex.Message, 500);
            }
        }
    }
}
