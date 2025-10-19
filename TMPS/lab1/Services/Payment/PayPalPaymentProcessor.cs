using LabSolid.Models;

namespace LabSolid.Services.Payment;

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine($"Processing PayPal payment for order {order.Id} - {order.TotalAmount}$");
    }
}