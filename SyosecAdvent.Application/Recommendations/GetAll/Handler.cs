using Mapster;
using MediatR;
using SyosecAdvent.Application.Common;
using SyosecAdvent.Application.Common.DTO;
using SyosecAdvent.Domain.Interfaces.Repositories;

namespace SyosecAdvent.Application.Recommendations.GetAll
{
    public class Handler : IRequestHandler<Request, GetAllResponse>
    {
        private readonly IUnitOfWorkAsync _Uow;

        public Handler(IUnitOfWorkAsync uow)
        {
            _Uow = uow;
        }

        public async Task<GetAllResponse> Handle(Request request, CancellationToken cancellationToken)
        {
           var result =  await _Uow
                                .RecommendationReadRepository
                                .GetAllAsync();

            if (result is null)
                return new GetAllResponse("busca sem resultado", 400);

            var count = result.Count();

            var resultDto = result.Adapt<IEnumerable<RecommendationDto>>();

            var items = resultDto.Skip((request.CurrentPage - 1) * request.PageSize).Take(request.PageSize); 

            var listResult = new PaginatedListResponse<RecommendationDto>(items, count, request.CurrentPage, request.PageSize);

            return new GetAllResponse("Listada com sucesso", listResult); 

            
        }
    }
}
