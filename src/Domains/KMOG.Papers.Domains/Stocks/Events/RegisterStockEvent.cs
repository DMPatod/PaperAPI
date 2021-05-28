using BuildingBlocks.Domains.DomainEvents;

namespace KMOG.Papers.Domains.Stocks.Events
{
    public class RegisterStockEvent : IDomainEvent
    {
        public Stock Stock { get; private set; }
        public RegisterStockEvent(Stock stock)
        {
            this.Stock = stock;
        }
    }
}
