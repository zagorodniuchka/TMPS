using TMPS.lab2.Models;

namespace TMPS.lab2.Patterns.Factory;

public class DroneFactory : TransportFactory
{
    public override Transport CreateTransport(string id)
    {
        return new Transport(id, "Drone", 50, 120);
    }
}