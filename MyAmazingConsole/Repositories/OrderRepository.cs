using MyAmazingConsole.Interfaces;
using MyAmazingConsole.Models;

namespace MyAmazingConsole.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders = new List<Order>();

    public void Add(Order order)
    {
        if (order == null) {
            throw new ArgumentNullException(nameof(order));
        }
        _orders.Add(order);
    }

    public Order? GetById(int id)
    {
        return _orders.FirstOrDefault(o => o.Id == id);
    }

    public IEnumerable<Order> GetAll()
    {
        return _orders;
    }

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

    public void Delete(int id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        if (order == null) {
            throw new KeyNotFoundException($"Order with Id {id} was not found.");
        }
        _orders.Remove(order);
    }
}
