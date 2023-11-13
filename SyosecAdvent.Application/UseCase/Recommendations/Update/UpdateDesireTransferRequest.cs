using MediatR;
using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update
{
    public class UpdateDesireTransferRequest : IRequest<DataRecommendationResponse>
    {
        public bool DesireTransfer { get; set; }
    }
}
