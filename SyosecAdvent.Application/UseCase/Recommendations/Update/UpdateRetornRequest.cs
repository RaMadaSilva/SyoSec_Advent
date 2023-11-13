using MediatR;
using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update
{
    public  class UpdateRetornRequest : IRequest<DataRecommendationResponse>
    {
        public string? UrlRecommendations { get; set; }
    }
}
