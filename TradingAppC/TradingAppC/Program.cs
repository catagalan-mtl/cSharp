using TradingAppC.data;
using TradingAppC.model;
using TradingAppC.service;

namespace TradingAppC
{
  class Program

  {
    public static async Task Main()
    {
      AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
      TradingAppCDbContext dbContext = new TradingAppCDbContext();
      MarketDataHttpHelper marketDataHttpHelper = new MarketDataHttpHelper("IBM", "demo");
      QuoteService quoteService = new QuoteService();

      AlphaQuote? alphaQuote;

      try
      {
        alphaQuote = await marketDataHttpHelper.CreateAlphaQuote();
        Console.WriteLine(
          "Alpha Quote Symbol: " + alphaQuote.Symbol
        );
        Quote? quote = quoteService.CreateQuoteObject(alphaQuote);
        Console.WriteLine("Quote Object created");
        Console.WriteLine($"{quote.Ticker} {quote.AskPrice} {quote.LastUpdated}");

        dbContext.Add<Quote>(quote);
        Console.WriteLine("Quote added to dbContext");
        await dbContext.SaveChangesAsync();
        Console.WriteLine("Changes saved. New Quote saved to Db");

      }
      catch (System.Exception e)
      {
        Console.WriteLine("Exception caught:");
        Console.WriteLine(e.Message + e.GetBaseException().Message);
      }

    }

  }
}
