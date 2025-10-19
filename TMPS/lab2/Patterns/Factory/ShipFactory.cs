using TMPS.lab2.Models;

namespace TMPS.lab2.Patterns.Factory;

public class ShipFactory : TransportFactory
{
    public override Transport CreateTransport(string id)
    {
        return new Transport(id, "Ship", 500000, 40);
    }
}