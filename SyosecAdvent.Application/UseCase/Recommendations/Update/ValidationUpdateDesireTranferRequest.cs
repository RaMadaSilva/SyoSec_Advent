using Flunt.Notifications;
using Flunt.Validations;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update
{
    public static class ValidationUpdateDesireTranferRequest
    {
        public static Contract<Notification> Ensure(UpdateDesireTransferRequest request)
            => new Contract<Notification>()
                   .Requires()
                   .IsTrue(request.DesireTransfer, "DesireTransfer", "O valor deve enviar um valor true");
    }
}
