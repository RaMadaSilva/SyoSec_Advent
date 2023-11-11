using SyosecAdvent.Application.Common;
using SyosecAdvent.Application.Common.DTO;

namespace SyosecAdvent.Application.Recommendations.GetById
{
    public class GetByIdResponse: Response
    {
        public GetByIdResponse()
        {
            
        }
        public GetByIdResponse(string message, int status)
        {
            Message = message; 
            StatusCode = status; 
        }

        public GetByIdResponse(string message, RecommendationDto data)
        {
            Message = message; 
            Data = data;
            StatusCode = 200; 
        }

        public RecommendationDto Data { get; set; }
    }
}
