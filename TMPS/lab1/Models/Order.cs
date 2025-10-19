namespace LabSolid.Models;

public class Order
{
    public string Id { get; }
    public string CustomerName { get; }
    public decimal TotalAmount { get; }

    public Order(string id, string customerName, decimal totalAmount)
    {
        Id = id;
        CustomerName = customerName;
        TotalAmount = totalAmount;
    }
}