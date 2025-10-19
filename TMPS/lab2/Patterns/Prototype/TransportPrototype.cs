using System;
using TMPS.lab2.Models;

namespace Lab2.Patterns.Prototype
{
    public abstract class TransportPrototype
    {
        public abstract Transport Clone();
    }

    public class TransportPrototypeImpl : TransportPrototype
    {
        private readonly Transport _transport;

        public TransportPrototypeImpl(Transport transport)
        {
            _transport = transport;
        }

        public override Transport Clone()
        {
            return new Transport(
                Guid.NewGuid().ToString().Substring(0, 6),
                _transport.Type,
                _transport.Capacity,
                _transport.Speed
            );
        }
    }
}