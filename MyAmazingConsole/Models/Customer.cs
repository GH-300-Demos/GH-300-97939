namespace MyAmazingConsole.Models;

/// <summary>
/// Represents a customer in the order management system.
/// </summary>
public class Customer
{
    /// <summary>Gets or sets the unique identifier for the customer.</summary>
    public int Id { get; set; }

    /// <summary>Gets or sets the last name of the customer.</summary>
    public string LastName { get; set; }

    /// <summary>Gets or sets the first name of the customer.</summary>
    public string FirstName { get; set; }

    /// <summary>Gets or sets the mailing address of the customer.</summary>
    public string Address { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Customer"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the customer.</param>
    /// <param name="lastName">The last name of the customer.</param>
    /// <param name="firstName">The first name of the customer.</param>
    /// <param name="address">The mailing address of the customer.</param>
    public Customer(int id, string lastName, string firstName, string address)
    {
        Id = id;
        LastName = lastName;
        FirstName = firstName;
        Address = address;
    }
}
