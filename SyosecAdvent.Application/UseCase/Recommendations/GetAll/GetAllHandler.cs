﻿using Mapster;
using MediatR;
using SyosecAdvent.Application.Common.DTO;
using SyosecAdvent.Application.Extensions;
using SyosecAdvent.Domain.Interfaces.Repositories;

namespace SyosecAdvent.Application.UseCase.Recommendations.GetAll
{
    public class GetAllHandler : IRequestHandler<GetAllRequest, GetAllResponse>
    {
        private readonly IUnitOfWorkAsync _Uow;

        public GetAllHandler(IUnitOfWorkAsync uow)
        {
            _Uow = uow;
        }

        public async Task<GetAllResponse> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _Uow
                                .RecommendationReadRepository
                                .GetAllAsync();

                if (result is null)
                    return new GetAllResponse("busca sem resultado", 400);

                var resultDto = result.Adapt<IEnumerable<RecommendationDto>>();

                var listResult = resultDto.ToPaginationsList<RecommendationDto>(request.CurrentPage, request.PageSize);

                return new GetAllResponse("Listada com sucesso", listResult);

            }
            catch (Exception ex)
            {
                return new GetAllResponse(ex.Message, 500);
            }
        }
    }
}
