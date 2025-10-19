using TMPS.lab2.Models;

namespace TMPS.lab2.Patterns.Singleton;

public class TransportRegistry
{
    private static readonly TransportRegistry _instance = new TransportRegistry();
    private readonly Dictionary<string, Transport> _transports = new();

    private TransportRegistry() { }

    public static TransportRegistry Instance => _instance;

    public void RegisterTransport(Transport transport)
    {
        if (!_transports.ContainsKey(transport.Id))
            _transports[transport.Id] = transport;
    }

    public Transport? GetTransport(string id)
    {
        _transports.TryGetValue(id, out var transport);
        return transport;
    }

    public List<string> ListTransports()
    {
        return new List<string>(_transports.Keys);
    }
}