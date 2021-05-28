using BuildingBlocks.Domains.DomainEvents;
using System;

namespace BuildingBlocks.Domains.Commons
{
    public abstract class Aggregate : DomainEventHolder
    {
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public DateTime Updated_At { get; set; }
    }
}
