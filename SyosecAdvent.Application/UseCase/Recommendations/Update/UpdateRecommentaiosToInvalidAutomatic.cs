using Microsoft.Extensions.Hosting;
using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update
{
    public class UpdateRecommentaiosToInvalidAutomatic : IHostedService, IDisposable
    {
        private readonly Recommendation _recommendation; 
        private Timer _timer;

        public UpdateRecommentaiosToInvalidAutomatic(Recommendation recommendation)
        {
            _recommendation = recommendation;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(UpdateToInvalid, null, TimeSpan.Zero, TimeSpan.FromDays(1));
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        private void UpdateToInvalid(object state)
        {
            _recommendation.UpdateStateRecommendationToInvalide(); 
        }
    }
}
