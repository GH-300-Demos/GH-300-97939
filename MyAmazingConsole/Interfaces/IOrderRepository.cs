using MyAmazingConsole.Models;

namespace MyAmazingConsole.Interfaces;

/// <summary>
/// Defines the contract for a repository that manages <see cref="Order"/> persistence.
/// </summary>
public interface IOrderRepository
{
    /// <summary>
    /// Adds a new order to the repository.
    /// </summary>
    /// <param name="order">The order to add.</param>
    void Add(Order order);

    /// <summary>
    /// Retrieves an order by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the order to retrieve.</param>
    /// <returns>The matching <see cref="Order"/>, or <c>null</c> if no order with the given identifier exists.</returns>
    Order? GetById(int id);

    /// <summary>
    /// Retrieves all orders in the repository.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}"/> containing all orders.</returns>
    IEnumerable<Order> GetAll();

    /// <summary>
    /// Replaces an existing order with the supplied updated order.
    /// </summary>
    /// <param name="order">The order containing updated data. Must match an existing order by <see cref="Order.Id"/>.</param>
    void Update(Order order);

    /// <summary>
    /// Removes the order with the specified identifier from the repository.
    /// </summary>
    /// <param name="id">The unique identifier of the order to delete.</param>
    void Delete(int id);
}
