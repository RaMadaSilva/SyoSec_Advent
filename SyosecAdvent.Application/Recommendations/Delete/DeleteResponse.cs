using Flunt.Notifications;
using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.Recommendations.Delete
{
    public class DeleteResponse : Response
    {
        public DeleteResponse()
        {
            
        }
        public DeleteResponse(string message, int statusCode)
        {
            Message = message;
            StatusCode = statusCode;
        }
        public DeleteResponse(string message, DataRecommendationResponse data)
        {
            Data = data;
            Message = message;
            StatusCode = 200; 
        }
        public DataRecommendationResponse? Data { get; set; }
    }
}
