﻿using SyoSec_Advent.Domain.ValueObject;
using System.Collections;
using System.Linq.Expressions;

namespace SyoSec_Advent.Domain.Entities
{
    public sealed class Church : Entity, IEquatable<Church>
    {
        private List<Recommendation> _recommendations = new();
        private Church()
        { }
        public Church(string nameChurch, Address addressChurch)
        {
            NameChurch = nameChurch;
            AddressChurch = addressChurch;
        }

        public string NameChurch { get; private set; }
        public Address AddressChurch { get; private set; }
        public IReadOnlyCollection<Recommendation> Recommendations { get =>_recommendations;}

        public void AddRecommendation(Recommendation recommendation) =>
            _recommendations.Add(recommendation);
        
        public bool Equals(Church? other)
        {
            return NameChurch ==other.NameChurch && 
                   AddressChurch == other.AddressChurch;
        }
    }
}