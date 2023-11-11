using MediatR;

namespace SyosecAdvent.Application.Recommendations.Delete
{
    public class Request : IRequest<DeleteResponse>
    {
        public long Id { get; set; }
    }
}
