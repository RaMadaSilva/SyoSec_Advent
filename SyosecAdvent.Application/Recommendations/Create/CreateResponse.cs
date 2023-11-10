using Flunt.Notifications;
using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.Recommendations.Create
{
    public class CreateResponse : Response
    {
        public CreateResponse() 
        {
        }

        public CreateResponse(string message, int statusCode)
        {
            Message = message;
            StatusCode = statusCode;    
        }

        public CreateResponse(string message, 
            int statusCode, 
            IEnumerable<Notification>? notifications = null)
        {
            Message = message;
            StatusCode = statusCode;
            Notifications = notifications;
        }

        public CreateResponse(CreateRecommendationData data, string message)
        {
            Data = data;
            Message = message;
            StatusCode = 201; 
        }

        public CreateRecommendationData? Data { get; set; }
    }

    public record CreateRecommendationData(long Id, 
        string Name, 
        string Church, 
        string RecommendationType);
}
