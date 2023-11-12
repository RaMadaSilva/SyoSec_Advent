using MediatR;

namespace SyosecAdvent.Application.Recommendations.Delete
{
    public class DeleteRequest : IRequest<DeleteResponse>
    {
        public long Id { get; set; }
    }
}
