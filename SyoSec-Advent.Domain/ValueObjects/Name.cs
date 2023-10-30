namespace SyosecAdvent.Domain.ValueObjects;
public sealed class Name: ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName {  get; private set; }  
    public string LastName { get; private set; }
} 
