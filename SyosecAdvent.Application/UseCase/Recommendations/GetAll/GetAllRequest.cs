﻿using MediatR;

namespace SyosecAdvent.Application.UseCase.Recommendations.GetAll
{
    public class GetAllRequest : IRequest<GetAllResponse>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}
