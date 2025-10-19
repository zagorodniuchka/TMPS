using LabSolid.Models;

namespace LabSolid.Services.Payment;

public class CardPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine($"Processing card payment for order {order.Id} - {order.TotalAmount}$");
    }
}