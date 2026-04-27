namespace MyAmazingConsole.Repositories;

using MyAmazingConsole.Models;

/// <summary>
/// Interface for managing orders
/// </summary>
public interface IOrderRepository
{
    /// <summary>
    /// Adds a new order to the repository
    /// </summary>
    void AddOrder(Order order);

    /// <summary>
    /// Retrieves an order by its ID
    /// </summary>
    Order GetOrder(string orderId);

    /// <summary>
    /// Removes an order from the repository
    /// </summary>
    bool RemoveOrder(string orderId);

    /// <summary>
    /// Gets all orders in the repository
    /// </summary>
    IReadOnlyList<Order> GetAllOrders();

    /// <summary>
    /// Gets orders filtered by status
    /// </summary>
    IReadOnlyList<Order> GetOrdersByStatus(OrderStatus status);

    /// <summary>
    /// Gets the total count of orders
    /// </summary>
    int GetOrderCount();

    /// <summary>
    /// Clears all orders from the repository
    /// </summary>
    void Clear();
}
