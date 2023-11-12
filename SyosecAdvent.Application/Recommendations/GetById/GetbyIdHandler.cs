using Mapster;
using MediatR;
using SyosecAdvent.Application.Common.DTO;
using SyosecAdvent.Domain.Interfaces.Repositories;

namespace SyosecAdvent.Application.Recommendations.GetById
{
    public class GetbyIdHandler : IRequestHandler<GetByIdRequest, GetByIdResponse>
    {
        private readonly IUnitOfWorkAsync _Uow;

        public GetbyIdHandler(IUnitOfWorkAsync uow)
        {
            _Uow = uow;
        }

        public async Task<GetByIdResponse> Handle(GetByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _Uow.RecommendationReadRepository.GetByIdAsync(request.Id);
                if (result is null)
                    return new GetByIdResponse("recomendação não encontrada", 404);
                var resultDto = request.Adapt<RecommendationDto>();

                return new GetByIdResponse("busca bem sucedida", resultDto); 

            }catch (Exception ex)
            {
                return new GetByIdResponse(ex.Message, 500);
            }
        }
    }
}
