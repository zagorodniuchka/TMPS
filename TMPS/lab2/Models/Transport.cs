namespace TMPS.lab2.Models;

public class Transport
{
    public string Id { get; set; }
    public string Type { get; set; }
    public int Capacity { get; set; }
    public double Speed { get; set; }
    public string Status { get; set; }

    public Transport(string id, string type, int capacity, double speed)
    {
        Id = id;
        Type = type;
        Capacity = capacity;
        Speed = speed;
        Status = "Available";
    }

    public override string ToString()
    {
        return $"{Type} [{Id}] - Capacity: {Capacity}kg, Speed: {Speed}km/h, Status: {Status}";
    }
}