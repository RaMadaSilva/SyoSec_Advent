using Flunt.Notifications;

namespace SyosecAdvent.Application.Common
{
    public abstract class Response
    {
        public string Message { get; set; } = string.Empty;
        public int StatusCode { get; set; }
        public IEnumerable<Notification>? Notifications { get; set; }
        public bool IsSuccess => StatusCode >= 200 && StatusCode <= 299;
    }
}
