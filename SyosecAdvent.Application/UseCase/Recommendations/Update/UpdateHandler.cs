using MediatR;
using SyosecAdvent.Application.Common;
using SyosecAdvent.Domain.Interfaces.Repositories;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update;

public class UpdateHandler : IRequestHandler<UpdateDesireTransferRequest, DataRecommendationResponse>,
    IRequestHandler<UpdateRetornRequest, DataRecommendationResponse>
{
    private readonly IUnitOfWorkAsync _Uow;

    public UpdateHandler(IUnitOfWorkAsync uow)
    {
        _Uow = uow;
    }

    public async Task<DataRecommendationResponse> Handle(UpdateDesireTransferRequest request, CancellationToken cancellationToken)
    {
        //1. Validar o Request,
        try
        {
            var notif = ValidationUpdateDesireTranferRequest.Ensure(request);
            if (!notif.IsValid)
            {
                return new DataRecommendationResponse("")
            }

        }catch (Exception ex)
        {

        }

        //2. Descer no banco para pegar o Objecto

        //3. Actualizar  e persistir as mudanças no banco

        //4. Retornar 
        throw new NotImplementedException();
    }

    public async Task<DataRecommendationResponse> Handle(UpdateRetornRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
