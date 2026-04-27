using MyAmazingConsole.Models;

namespace MyAmazingConsole.Interfaces;

public interface IOrderRepository
{
    void Add(Order order);
    Order? GetById(int id);
    IEnumerable<Order> GetAll();
    void Update(Order order);
    void Delete(int id);
}
