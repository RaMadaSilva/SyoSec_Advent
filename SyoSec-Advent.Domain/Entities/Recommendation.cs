using SyosecAdvent.Domain.Enums;

namespace SyosecAdvent.Domain.Entities
{
    public sealed class Recommendation : Entity
    {
        private const int PERIODVALIDITY = 120;
        private Recommendation()
        {

        }
        public Recommendation(Member member,
                    Church church,
                    string observation,
                    ERecommendationType recommendationType)
        {
            Member = member;
            Church = church;
            Observation = observation;
            DateRegister = DateTime.UtcNow;
            DesireTrasfer = false;
            RecommendationState = ERecommendationState.Valido;
            RecommendationType = recommendationType;
            ExpireDate = DateRegister.AddDays(PERIODVALIDITY); 
        }

        public Member Member { get; private set; }
        public Church Church { get; private set; }
        public string Observation { get; private set; }
        public DateTime DateRegister { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public DateTime? DateReturn { get; private set; }
        public string? UrlRecommendation { get; private set; }
        public bool DesireTrasfer { get; private set; }
        public ERecommendationState RecommendationState { get; private set; }
        public ERecommendationType RecommendationType { get; private set; }
        public int ExpireIn { get => (int)Math.Ceiling(ExpireDate.Subtract(DateTime.UtcNow).TotalDays); }

        public void UpdateStateRecommendationToInvalide()
        {
  
            if (ExpireIn < 0 && RecommendationState == ERecommendationState.Valido)
                    RecommendationState = ERecommendationState.Invalido;
        }

        public bool UpdateStatRecommendationToDevolvido(DateTime date)
        {
            if (DateReturn != null)
                return false;

            DateReturn = date;
            RecommendationState = ERecommendationState.Devolvido;
            return true;
        }

        public bool UpdateStateRecommendationToTransferencia(bool desire)
        {

            if (!DesireTrasfer && desire)
            {
                DesireTrasfer = desire;
                RecommendationState = ERecommendationState.Transferencia;
                return true;
            }
            return false;
        }
    }
}
