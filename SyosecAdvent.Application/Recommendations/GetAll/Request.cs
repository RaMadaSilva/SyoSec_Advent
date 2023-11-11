using MediatR;
using SyosecAdvent.Application.Common;
using SyosecAdvent.Application.Common.DTO;

namespace SyosecAdvent.Application.Recommendations.GetAll
{
    public class Request : IRequest<PaginatedListResponse<RecommendationDto>>
    {
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }
}
