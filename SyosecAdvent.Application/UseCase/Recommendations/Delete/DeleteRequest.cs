using MediatR;

namespace SyosecAdvent.Application.UseCase.Recommendations.Delete
{
    public class DeleteRequest : IRequest<DeleteResponse>
    {
        public long Id { get; set; }
    }
}
