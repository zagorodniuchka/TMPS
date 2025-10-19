using TMPS.lab2.Models;

namespace TMPS.lab2.Patterns.Factory;

public class TruckFactory : TransportFactory
{
    public override Transport CreateTransport(string id)
    {
        return new Transport(id, "Truck", 10000, 90);
    }
}