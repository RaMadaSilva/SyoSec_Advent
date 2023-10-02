using SyoSec_Advent.Domain.Enums;

namespace SyoSec_Advent.Domain.Entities
{
    public sealed class Recommendation: Entity
    {
        public Recommendation(Member member, 
                    Church church, 
                    string observation, 
                    ERecommendationState recommendationState, 
                    ERecommendationType recommendationType)
        {
            Member = member;
            Church = church;
            Observation = observation;
            DateRegister = DateTime.UtcNow; 
            DesireTrasfer = false;
            RecommendationState = recommendationState;
            RecommendationType = recommendationType;
        }

        public Member Member { get; private set; }
        public Church Church { get; private set; }
        public string Observation { get; private set; }
        public DateTime? DateReturn { get; private set; }
        public DateTime DateRegister { get; private set; }
        public string? UrlRecommendation { get; private set; }
        public bool DesireTrasfer { get; private set; }
        public ERecommendationState  RecommendationState { get; private set; }
        public ERecommendationType RecommendationType { get; private set; }

    }
}
