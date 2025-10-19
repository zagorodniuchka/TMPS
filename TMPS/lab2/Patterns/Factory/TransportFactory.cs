using TMPS.lab2.Models;

namespace TMPS.lab2.Patterns.Factory;

public abstract class TransportFactory
{
    public abstract Transport CreateTransport(string id);
}