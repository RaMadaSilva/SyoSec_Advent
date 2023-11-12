using SyosecAdvent.Application.Common;
using SyosecAdvent.Application.Common.DTO;

namespace SyosecAdvent.Application.UseCase.Recommendations.GetAll
{
    public class GetAllResponse : Response
    {
        public GetAllResponse()
        {

        }
        public GetAllResponse(string message, int status)
        {
            Message = message;
            StatusCode = status;
        }
        public GetAllResponse(string message, PaginatedListResponse<RecommendationDto>? listResponse)
        {
            Message = message;
            ListResponse = listResponse;
            StatusCode = 200;
        }

        public PaginatedListResponse<RecommendationDto>? ListResponse { get; set; }
    }
}
