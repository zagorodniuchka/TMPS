using LabSolid.Models;

namespace LabSolid.Services.Payment;

public interface IPaymentProcessor
{
    void ProcessPayment(Order order);
}