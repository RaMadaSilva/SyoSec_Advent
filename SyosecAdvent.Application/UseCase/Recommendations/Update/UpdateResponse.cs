using Flunt.Notifications;
using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update
{
    public class UpdateResponse : Response
    {
        public UpdateResponse()
        {
            
        }
        public UpdateResponse(string message, int status)
        {
            Message = message; 
            StatusCode = status;
        }
        public UpdateResponse(string message, int status, IEnumerable<Notification>? notifications)
        {
            Message = message;
            StatusCode = status;
            Notifications = notifications;   
        }

        public UpdateResponse(string message, DataRecommendationResponse data)
        {
            Message = message;
            Data = data;
            StatusCode = 200; 
        }

        public DataRecommendationResponse Data { get; set; }
    }
}
