using MediatR;

namespace SyosecAdvent.Application.UseCase.Recommendations.GetById
{
    public sealed class GetByIdRequest : IRequest<GetByIdResponse>
    {
        public long Id { get; set; }
    }
}
