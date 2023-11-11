using Flunt.Notifications;

namespace SyosecAdvent.Application.Common
{
    public class ResponseClient : Response
    {
        public ResponseClient()
        {
        }

        public ResponseClient(string message, int statusCode)
        {
            Message = message;
            StatusCode = statusCode;
        }

        public ResponseClient(string message,
            int statusCode,
            IEnumerable<Notification>? notifications = null)
        {
            Message = message;
            StatusCode = statusCode;
            Notifications = notifications;
        }
    }
}
