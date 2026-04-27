namespace MyAmazingConsole.Models;

public class Customer
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Address { get; set; }

    public Customer(int id, string lastName, string firstName, string address)
    {
        Id = id;
        LastName = lastName;
        FirstName = firstName;
        Address = address;
    }
}
