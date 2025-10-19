using LabSolid.Models;

namespace LabSolid.Services.Reporting;

public class OrderReport : IPrintable, IExportable
{
    private readonly IEnumerable<Order> _orders;

    public OrderReport(IEnumerable<Order> orders)
    {
        _orders = orders;
    }

    public void Print()
    {
        Console.WriteLine("=== Orders Report ===");
        foreach (var order in _orders)
            Console.WriteLine($"ID: {order.Id}, Customer: {order.CustomerName}, Total: {order.TotalAmount}$");
    }

    public void ExportToFile(string filePath)
    {
        using var writer = new StreamWriter(filePath);
        writer.WriteLine("OrderId,CustomerName,TotalAmount");
        foreach (var order in _orders)
            writer.WriteLine($"{order.Id},{order.CustomerName},{order.TotalAmount}");
        Console.WriteLine($"Report exported to {filePath}");
    }
}