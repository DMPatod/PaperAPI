namespace BuildingBlocks.Domains.DomainEvents
{
    public interface IDomainEventHandler<in TDomainEvent>
        where TDomainEvent : IDomainEvent
    {
    }
}
