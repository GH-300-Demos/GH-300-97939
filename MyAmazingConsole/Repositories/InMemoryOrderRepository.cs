namespace MyAmazingConsole.Repositories;

using MyAmazingConsole.Models;

/// <summary>
/// In-memory implementation of the order repository
/// </summary>
public class InMemoryOrderRepository : IOrderRepository
{
    private readonly Dictionary<string, Order> _orders = new();

    /// <summary>
    /// Adds a new order to the repository
    /// </summary>
    public void AddOrder(Order order)
    {
        if (order == null)
            throw new ArgumentNullException(nameof(order));

        if (_orders.ContainsKey(order.OrderId))
            throw new InvalidOperationException($"Order with ID '{order.OrderId}' already exists.");

        _orders[order.OrderId] = order;
    }

    /// <summary>
    /// Retrieves an order by its ID
    /// </summary>
    public Order GetOrder(string orderId)
    {
        if (string.IsNullOrWhiteSpace(orderId))
            throw new ArgumentException("Order ID cannot be null or empty.", nameof(orderId));

        if (!_orders.TryGetValue(orderId, out var order))
            throw new KeyNotFoundException($"Order with ID '{orderId}' not found.");

        return order;
    }

    /// <summary>
    /// Removes an order from the repository
    /// </summary>
    public bool RemoveOrder(string orderId)
    {
        if (string.IsNullOrWhiteSpace(orderId))
            throw new ArgumentException("Order ID cannot be null or empty.", nameof(orderId));

        return _orders.Remove(orderId);
    }

    /// <summary>
    /// Gets all orders in the repository
    /// </summary>
    public IReadOnlyList<Order> GetAllOrders()
    {
        return _orders.Values.ToList().AsReadOnly();
    }

    /// <summary>
    /// Gets orders filtered by status
    /// </summary>
    public IReadOnlyList<Order> GetOrdersByStatus(OrderStatus status)
    {
        return _orders.Values
            .Where(o => o.Status == status)
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Gets the total count of orders
    /// </summary>
    public int GetOrderCount()
    {
        return _orders.Count;
    }

    /// <summary>
    /// Clears all orders from the repository
    /// </summary>
    public void Clear()
    {
        _orders.Clear();
    }
}
