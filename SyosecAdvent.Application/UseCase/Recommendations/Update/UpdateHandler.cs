using MediatR;
using SyosecAdvent.Application.Common;
using SyosecAdvent.Domain.Entities;
using SyosecAdvent.Domain.Interfaces.Repositories;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update;

public class UpdateHandler : IRequestHandler<UpdateDesireTransferRequest, UpdateResponse>,
                         IRequestHandler<UpdateRetornRequest, UpdateResponse>
{
    private readonly IUnitOfWorkAsync _Uow;

    public UpdateHandler(IUnitOfWorkAsync uow)
    {
        _Uow = uow;
    }

    public async Task<UpdateResponse> Handle(UpdateDesireTransferRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var notif = ValidationUpdateDesireTranferRequest.Ensure(request);
            if (!notif.IsValid)
            {
                return new UpdateResponse("request invalido", 400, notif.Notifications);
            }

        }
        catch (Exception ex)
        {
            return new UpdateResponse(ex.Message, 500);
        }

        Recommendation recommendationBd;
        try
        {
            recommendationBd = await _Uow.RecommendationReadRepository.GetByIdAsync(request.Id);

            if (recommendationBd is null)
                return new UpdateResponse("recomendação não foi encontrada!", 400);
        }
        catch (Exception ex)
        {
            return new UpdateResponse(ex.Message, 500);
        }

        try
        {
            var result = recommendationBd.UpdateStateRecommendationToTransferencia(request.DesireTransfer);
            if (!result)
                return new UpdateResponse("Não foi possivel actualizar!", 404);

            await _Uow.RecommendationWriteRepository.UpdateAsync(recommendationBd);
            var data = new DataRecommendationResponse(recommendationBd.Id,
                            recommendationBd.Member.NameMember.ToString(),
                            recommendationBd.Church.NameChurch,
                            Enum.GetName(recommendationBd.RecommendationType));

            return new UpdateResponse("Actualização bem sucedida", data);
        }
        catch (Exception ex)
        {
            return new UpdateResponse(ex.Message, 500); 
        }
    }

    public async Task<UpdateResponse> Handle(UpdateRetornRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var notif = ValidationUpdateRetornRequest.Ensure(request);
            if (!notif.IsValid)
            {
                return new UpdateResponse("request invalido", 400, notif.Notifications);
            }

        }
        catch (Exception ex)
        {
            return new UpdateResponse(ex.Message, 500);
        }

        Recommendation recommendationBd;
        try
        {
            recommendationBd = await _Uow.RecommendationReadRepository.GetByIdAsync(request.Id);

            if (recommendationBd is null)
                return new UpdateResponse("recomendação não foi encontrada!", 400);
        }
        catch (Exception ex)
        {
            return new UpdateResponse(ex.Message, 500);
        }

        try
        {
           recommendationBd.UpdateStatRecommendationToDevolvido(DateTime.UtcNow);
            
            await _Uow.RecommendationWriteRepository.UpdateAsync(recommendationBd);
            var data = new DataRecommendationResponse(recommendationBd.Id,
                            recommendationBd.Member.NameMember.ToString(),
                            recommendationBd.Church.NameChurch,
                            Enum.GetName(recommendationBd.RecommendationType));

            return new UpdateResponse("Actualização bem sucedida", data);
        }
        catch (Exception ex)
        {
            return new UpdateResponse(ex.Message, 500);
        }
    }
}
