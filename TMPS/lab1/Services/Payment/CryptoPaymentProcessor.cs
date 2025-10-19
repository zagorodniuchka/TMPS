using LabSolid.Models;

namespace LabSolid.Services.Payment;

public class CryptoPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine($"Processing crypto payment for order {order.Id} - {order.TotalAmount}$");
    }
}