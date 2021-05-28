using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace KMOG.PaperTests.Stocks
{
    public class ExternalStockData
    {
        public static IEnumerable<object[]> StockData
        {
            get
            {
                string[] csvLines = File.ReadAllLines("Stocks/StocksTestData.csv");

                var testCases = new List<object[]>();

                foreach (var line in csvLines)
                {
                    IEnumerable<decimal> values = line.Split(',').Select(str => decimal.Parse(str, new CultureInfo("en-US")));

                    object[] testCase = values.Cast<object>().ToArray();

                    testCases.Add(testCase);
                }
                return testCases;
            }
        }
    }
}
