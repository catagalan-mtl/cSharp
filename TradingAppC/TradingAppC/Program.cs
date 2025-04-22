using TradingAppC.data;
using TradingAppC.model;

namespace TradingAppC
{
  class Program
  {
    public static async Task Main()
    {
      AlphaQuote alphaQuote;
      MarketDataHttpHelper marketDataHttpHelper = new MarketDataHttpHelper("IBM", "demo");

      Console.WriteLine(await marketDataHttpHelper.GetJsonAlphaQuote());
      try
      {
        alphaQuote = await marketDataHttpHelper.CreateAlphaQuote();
        Console.WriteLine(
          "Alpha Quote Symbol: " + alphaQuote.Symbol
        );
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Unable to deserialize responseBody to AlphaQuote. Exception caught:");
        Console.WriteLine(e.Message);
      }
    }
  }
}
