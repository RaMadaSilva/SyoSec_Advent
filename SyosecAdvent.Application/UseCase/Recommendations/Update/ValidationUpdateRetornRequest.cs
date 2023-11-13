using Flunt.Notifications;
using Flunt.Validations;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update
{
    public static class ValidationUpdateRetornRequest
    {
        public static Contract<Notification> Ensure(UpdateRetornRequest request)
            => new Contract<Notification>()
                    .Requires()
                    .IsGreaterThan(request.UrlRecommendations, 20, "UrlRecommendations", "A URL deve ter mais de 20 caracteres"); 
    }
}
