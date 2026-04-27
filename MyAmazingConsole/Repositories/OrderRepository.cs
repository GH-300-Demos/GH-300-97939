using MyAmazingConsole.Interfaces;
using MyAmazingConsole.Models;

namespace MyAmazingConsole.Repositories;

/// <summary>
/// An in-memory implementation of <see cref="IOrderRepository"/> for managing <see cref="Order"/> objects.
/// </summary>
public class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders = new List<Order>();

    /// <summary>
    /// Adds a new order to the in-memory store.
    /// </summary>
    /// <param name="order">The order to add.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="order"/> is <c>null</c>.</exception>
    public void Add(Order order)
    {
        if (order == null) {
            throw new ArgumentNullException(nameof(order));
        }
        _orders.Add(order);
    }

    /// <summary>
    /// Retrieves an order by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the order to retrieve.</param>
    /// <returns>The matching <see cref="Order"/>, or <c>null</c> if no order with the given identifier exists.</returns>
    public Order? GetById(int id)
    {
        return _orders.FirstOrDefault(o => o.Id == id);
    }

    /// <summary>
    /// Retrieves all orders currently held in the in-memory store.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}"/> containing all orders.</returns>
    public IEnumerable<Order> GetAll()
    {
        return _orders;
    }

    /// <summary>
    /// Replaces an existing order with the supplied updated order.
    /// </summary>
    /// <param name="order">The order containing updated data. Must match an existing order by <see cref="Order.Id"/>.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="order"/> is <c>null</c>.</exception>
    /// <exception cref="KeyNotFoundException">Thrown when no order with the given identifier exists in the store.</exception>
    public void Update(Order order)
    {
        if (order == null) {
            throw new ArgumentNullException(nameof(order));
        }
        var existing = _orders.FirstOrDefault(o => o.Id == order.Id);
        if (existing == null) {
            throw new KeyNotFoundException($"Order with Id {order.Id} was not found.");
        }
        var index = _orders.IndexOf(existing);
        _orders[index] = order;
    }

    /// <summary>
    /// Removes the order with the specified identifier from the in-memory store.
    /// </summary>
    /// <param name="id">The unique identifier of the order to delete.</param>
    /// <exception cref="KeyNotFoundException">Thrown when no order with the given identifier exists in the store.</exception>
    public void Delete(int id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        if (order == null) {
            throw new KeyNotFoundException($"Order with Id {id} was not found.");
        }
        _orders.Remove(order);
    }
}
