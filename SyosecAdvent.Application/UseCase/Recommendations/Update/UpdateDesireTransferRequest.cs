using MediatR;
using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update
{
    public class UpdateDesireTransferRequest : IRequest<DataRecommendationResponse>
    {
        public long Id { get; set; }
        public bool DesireTransfer { get; set; }
    }
}
