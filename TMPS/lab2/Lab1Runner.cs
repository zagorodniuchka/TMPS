using Lab2.Patterns.Prototype;
using TMPS.lab2.Patterns.Factory;
using TMPS.lab2.Patterns.Singleton;

namespace TMPS.lab2;

public class Lab2Runner
{
    public void Run()
    {
        Console.WriteLine("=== Logistics Transport System ===\n");

        // --- Factory ---
        TransportFactory truckFactory = new TruckFactory();
        TransportFactory droneFactory = new DroneFactory();
        TransportFactory shipFactory = new ShipFactory();

        var truck = truckFactory.CreateTransport("TRK001");
        var drone = droneFactory.CreateTransport("DRN001");
        var ship = shipFactory.CreateTransport("SHP001");

        Console.WriteLine("Created using Factory:");
        Console.WriteLine(truck);
        Console.WriteLine(drone);
        Console.WriteLine(ship);

        // --- Prototype ---
        var prototype = new TransportPrototypeImpl(drone);
        var clonedDrone = prototype.Clone();
        Console.WriteLine($"\nCloned using Prototype: {clonedDrone}");

        // --- Singleton ---
        var registry = TransportRegistry.Instance;
        registry.RegisterTransport(truck);
        registry.RegisterTransport(drone);
        registry.RegisterTransport(ship);
        registry.RegisterTransport(clonedDrone);

        Console.WriteLine("\nRegistered transports:");
        foreach (var id in registry.ListTransports())
            Console.WriteLine($"- {id}");

        var anotherRegistry = TransportRegistry.Instance;
        Console.WriteLine($"\nSingleton check (same instance): {ReferenceEquals(registry, anotherRegistry)}");
    }
}