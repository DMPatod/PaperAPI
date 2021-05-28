using BuildingBlocks.Domains.Commons;
using KMOG.Papers.Domains.Stocks.Events;
using System;

namespace KMOG.Papers.Domains.Stocks
{
    public class Stock : Aggregate
    {
        public Stock()
        {
            // For Ef Only
        }
        public Stock(string ticket, string issuer, string classification, decimal currentValue)
        {
            this.Ticket = ticket;
            this.Issuer = issuer;
            this.Classification = classification;
            if (currentValue <= 0)
            {
                throw new Exception("A Stock cannot have a negative market value");
            }
            this.Value = currentValue;
        }
        public Guid id { get; set; }
        public string Ticket { get; set; }
        public string Issuer { get; set; }
        public string Classification { get; set; }
        public decimal Value { get; set; }
        public decimal ValueD1 { get; set; }
        public decimal UpdateValue(decimal currentValue)
        {
            if (currentValue <= 0)
            {
                throw new Exception("A Stock cannot have a negative market value");
            }
            ValueD1 = this.Value;
            this.Value = currentValue;
            return currentValue;
        }
        public static Stock AddStock(string ticket, string issuer, string classification, decimal currentValue)
        {
            var entity = new Stock(ticket, issuer, classification, currentValue);
            entity.AddDomainEvent(new RegisterStockEvent(entity));
            return entity;
        }
    }
}
