namespace MyAmazingConsole.Models;

/// <summary>
/// Represents a customer order in the order management system.
/// </summary>
public class Order
{
    /// <summary>Gets or sets the unique identifier for the order.</summary>
    public int Id { get; set; }

    /// <summary>Gets or sets the customer who placed the order.</summary>
    public Customer Customer { get; set; }

    /// <summary>Gets or sets the list of items included in the order.</summary>
    public List<OrderItem> Items { get; set; }

    /// <summary>Gets the total cost of the order, calculated as the sum of all item costs.</summary>
    public decimal TotalCost
    {
        get { return Items.Sum(item => item.TotalCost); }
    }

    /// <summary>Gets or sets the current status of the order.</summary>
    public OrderStatus Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Order"/> class with an empty item list
    /// and a status of <see cref="OrderStatus.Created"/>.
    /// </summary>
    /// <param name="id">The unique identifier for the order.</param>
    /// <param name="customer">The customer who placed the order.</param>
    public Order(int id, Customer customer)
    {
        Id = id;
        Customer = customer;
        Items = new List<OrderItem>();
        Status = OrderStatus.Created;
    }
}
