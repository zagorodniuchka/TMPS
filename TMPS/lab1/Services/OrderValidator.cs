using LabSolid.Models;

namespace LabSolid.Services;

public class OrderValidator
{
    public bool Validate(Order order)
    {
        return !string.IsNullOrWhiteSpace(order.Id)
               && !string.IsNullOrWhiteSpace(order.CustomerName)
               && order.TotalAmount > 0;
    }
}