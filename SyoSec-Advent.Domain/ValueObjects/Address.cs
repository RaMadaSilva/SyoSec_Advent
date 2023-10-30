namespace SyosecAdvent.Domain.ValueObjects;

public sealed class Address : ValueObject
{
    public Address(string street, string city, string province)
    {
        Street = street;
        City = city;
        Province = province;
    }

    public string Street { get;  private set; }
    public string City { get; private set; }
    public string Province { get; private set; }

}
