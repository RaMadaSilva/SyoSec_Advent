using MediatR;
using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update
{
    public class UpdateDesireTransferRequest : IRequest<UpdateResponse>
    {
        public long Id { get; set; }
        public bool DesireTransfer { get; set; }
    }
}
