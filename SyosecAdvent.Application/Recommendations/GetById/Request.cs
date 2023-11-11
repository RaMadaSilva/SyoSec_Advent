using MediatR;

namespace SyosecAdvent.Application.Recommendations.GetById
{
    public sealed class Request : IRequest<GetByIdResponse>
    {
        public long Id { get; set; }
    }
}
