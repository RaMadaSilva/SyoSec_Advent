using Flunt.Notifications;
using Flunt.Validations;

namespace SyosecAdvent.Application.Recommendations.Create
{
    public  static class ValidationRequest
    {
        public static Contract<Notification> Ensure(Request request)
            => new Contract<Notification>().Requires(); 
    }
}
