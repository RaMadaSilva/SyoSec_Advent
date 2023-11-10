using MediatR;
using SyosecAdvent.Domain.Enums;

namespace SyosecAdvent.Application.Recommendations.Create
{
    public class Request: IRequest<Response>
    {
        #region 1 Member
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty; 
        public string Phone { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty; 
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;

        #endregion

        #region 2 Church
        public string ChurchName { get; set; } = string.Empty;
        public string ChurchStreet { get; set; } = string.Empty;
        public string ChurchCity { get; set; } = string.Empty; 
        public string ChurchProvince { get; set; } = string.Empty;
        #endregion

        public string Observation { get; set; } = string.Empty;
        public ERecommendationType RecommendationType { get; set; }
    }

}
