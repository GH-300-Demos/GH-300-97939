namespace MyAmazingConsole.Models;

public class Order
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public List<OrderItem> Items { get; set; }
    public decimal TotalCost
    {
        get { return Items.Sum(item => item.TotalCost); }
    }
    public OrderStatus Status { get; set; }

    public Order(int id, Customer customer)
    {
        Id = id;
        Customer = customer;
        Items = new List<OrderItem>();
        Status = OrderStatus.Created;
    }
}
