namespace MyAmazingConsole.Models;

/// <summary>
/// Represents customer information
/// </summary>
public class CustomerInfo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

    public CustomerInfo(string firstName, string lastName, string address)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        Address = address ?? throw new ArgumentNullException(nameof(address));
    }

    public override string ToString() => $"{FirstName} {LastName}, {Address}";
}
