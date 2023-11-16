using SyosecAdvent.Domain.ValueObjects;

namespace SyosecAdvent.Domain.Entities
{
    public sealed class  Member : Entity, IEquatable<Member>
    {
        private List<Recommendation> _recommendations; 
        private Member() { }
        public Member(Name nameMember, string phone, Address address)
        {
            NameMember = nameMember;
            Phone = phone;
            AddressMember = address;
        }

        public Name NameMember { get; private set; }
        public string Phone { get; private set; }
        public Address AddressMember { get; private set; }
        public Church Church { get; private set; }

        public IReadOnlyCollection<Recommendation> Recommendations { get => _recommendations; }

        public void AddRecommendation(Recommendation recommendation) 
            =>_recommendations.Add(recommendation);

        public bool Equals(Member? other)
        {
            if (other is null) 
                return false;
            return NameMember == other.NameMember &&
                   Phone == other.Phone &&
                   AddressMember == other.AddressMember; 

        }
    }
}
