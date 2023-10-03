﻿using SyoSec_Advent.Domain.Enums;

namespace SyoSec_Advent.Domain.Entities
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
        }

        public Member Member { get; private set; }
        public Church Church { get; private set; }
        public string Observation { get; private set; }
        public DateTime? DateReturn { get; private set; }
        public DateTime DateRegister { get; private set; }
        public string? UrlRecommendation { get; private set; }
        public bool DesireTrasfer { get; private set; }
        public ERecommendationState RecommendationState { get; private set; }
        public ERecommendationType RecommendationType { get; private set; }

        public bool UpdateStateRecommendationToInvalide()
        {
            var validateDate = DateTime.UtcNow.Subtract(DateRegister).TotalDays;

            if (validateDate >= PERIODVALIDITY
                && RecommendationState == ERecommendationState.Valido)
            {
                RecommendationState = ERecommendationState.Invalido;
                return true;
            }
            return false;
        }

        public bool UpdateStatRecommendationToDevolvido(DateTime date)
        {
            if (DateReturn != null)
                return false;

            DateReturn = date;
            RecommendationState = ERecommendationState.Devolvido;
            return true;
        }

        public void UpdateStateRecommendationToTransferencia()
        {
            //TODO
        }

    }
}
