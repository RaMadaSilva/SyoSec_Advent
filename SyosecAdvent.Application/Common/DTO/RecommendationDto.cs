using SyosecAdvent.Domain.Enums;

namespace SyosecAdvent.Application.Common.DTO
{
    public class RecommendationDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;

        public string ChurchName { get; set; } = string.Empty;
        public string ChurchStreet { get; set; } = string.Empty;
        public string ChurchCity { get; set; } = string.Empty;
        public string ChurchProvince { get; set; } = string.Empty;

        public string Observation { get; set; } = string.Empty;
        public DateTime? DateReturn { get; set; }
        public DateTime DateRegister { get; set; }
        public string? UrlRecommendation { get; set; }
        public bool DesireTrasfer { get; set; }
        public ERecommendationState RecommendationState { get; set; }
        public ERecommendationType RecommendationType { get; set; }
    }
}
