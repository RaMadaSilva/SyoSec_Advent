using MediatR;

namespace SyosecAdvent.Application.Recommendations.GetAll
{
    public class Request : IRequest<GetAllResponse>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}
