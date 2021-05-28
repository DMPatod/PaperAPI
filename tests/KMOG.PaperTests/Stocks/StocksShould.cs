using KMOG.Papers.Domains.Stocks;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace KMOG.PaperTests.Stocks
{
    public class StocksShould
    {
        private readonly ITestOutputHelper output;
        private readonly Stock sut;
        public StocksShould(ITestOutputHelper output)
        {
            sut = new Stock("URA", "Global X", "Uranium", 22.52m);
            this.output = output;
        }

        [Theory]
        [MemberData(nameof(ExternalStockData.StockData), MemberType = typeof(ExternalStockData))]
        public async Task UpdateValue(decimal currentValue, decimal valued1)
        {
            sut.UpdateValue(currentValue);

            Assert.Equal(currentValue, sut.Value);
        }
    }
}
