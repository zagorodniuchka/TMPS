# Laboratory Work: SOLID Principles in C#

## Objective

Demonstrate the application of **three SOLID principles** — SRP, OCP, and ISP — using an order management system example.

## Applied Principles
1. **SRP — Single Responsibility Principle**

Each class performs a single, well-defined task:
- OrderValidator — validates the order data
- OrderRepository — stores and retrieves orders
- This separation makes the code easier to maintain and test — changing validation logic won’t affect storage.

2. **OCP — Open/Closed Principle**

- The IPaymentProcessor interface allows adding new payment methods
  (such as CardPaymentProcessor, PayPalPaymentProcessor, or CryptoPaymentProcessor)
  without modifying the existing code.

The system is open for extension, closed for modification thanks to the use of interfaces.

3. **ISP — Interface Segregation Principle**

Interfaces are divided by responsibility:
- IPrintable — handles screen output
- IExportable — handles file export

The OrderReport class implements both,
but other classes can implement only the interfaces they actually need — avoiding unnecessary dependencies.

## Program Output

**Console output:**

Order 001 saved successfully.
Order 002 saved successfully.
Processing crypto payment for order 001 - 120.5$

 Orders Report

ID: 001, Customer: Alice, Total: 120.5
ID: 002, Customer: Bob, Total: 300$
Report exported to orders_report.csv

**How It Works**

The user creates new orders (Order).
OrderValidator checks if the data is valid.
OrderRepository stores all valid orders in memory.
The chosen payment method is processed via the IPaymentProcessor interface.
OrderReport displays all orders and exports them to a .csv file.

## Conclusion

This project demonstrates three SOLID principles in practice:

**SRP** — clear separation of responsibilities
**OCP** — extensibility without modifying existing code
**ISP** — flexible, lightweight interfaces

The result is a clean, modular, and easily maintainable system that can be extended with new payment methods or reporting features without breaking existing functionality.