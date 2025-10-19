using LabSolid.Models;

namespace LabSolid.Services;

public class OrderRepository
{
    private readonly List<Order> _orders = new();

    public void Save(Order order)
    {
        _orders.Add(order);
        Console.WriteLine($"Order {order.Id} saved successfully.");
    }

    public IEnumerable<Order> GetAll() => _orders;
}