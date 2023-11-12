using Flunt.Notifications;
using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.UseCase.Recommendations.Create
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

        public CreateResponse(string message, DataRecommendationResponse data)
        {
            Data = data;
            Message = message;
            StatusCode = 201;
        }

        public DataRecommendationResponse? Data { get; set; }
    }

}
