using LabSolid.Models;
using LabSolid.Services;
using LabSolid.Services.Payment;
using LabSolid.Services.Reporting;

class Lab1Runner
{
    public void Run()
    {
        var validator = new OrderValidator();
        var repository = new OrderRepository();

        var order1 = new Order("001", "Alice", 120.50m);
        var order2 = new Order("002", "Bob", 300m);

        // SRP — проверка и сохранение
        if (validator.Validate(order1)) repository.Save(order1);
        if (validator.Validate(order2)) repository.Save(order2);

        // OCP — легко меняем способ оплаты
        IPaymentProcessor paymentProcessor = new CryptoPaymentProcessor();
        paymentProcessor.ProcessPayment(order1);

        // ISP — отчёт печатается и экспортируется
        var report = new OrderReport(repository.GetAll());
        report.Print();
        report.ExportToFile("orders_report.csv");
    }
}