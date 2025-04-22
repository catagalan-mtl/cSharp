using TradingAppC.data;

namespace TradingAppC
{
  class Program
  {
    public static async Task Main()
    {
      MarketDataHttpHelper marketDataHttpHelper = new MarketDataHttpHelper("IBM", "demo");
      // await marketDataHttpHelper.GetJsonAlphaQuote();

      Console.WriteLine(await marketDataHttpHelper.GetJsonAlphaQuote());
    }
  }
}
