﻿using MediatR;

namespace SyosecAdvent.Application.UseCase.Recommendations.Update
{
    public class UpdateRetornRequest : IRequest<UpdateResponse>
    {
        public long Id { get; set; }
        public string? UrlRecommendations { get; set; }
    }
}
