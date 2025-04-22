using System;
using TradingAppC.model;

namespace TradingAppC.service;

public class QuoteService
{
  public Quote? CreateQuoteObject(AlphaQuote? alphaQuote)
  {
    if (alphaQuote is not null)
    {
      float price = float.Parse(alphaQuote.Price);
      float spread = (float)(price * 0.05);
      float bidPrice = price - spread;
      float askPrice = price + spread;

      Quote quote = new Quote
      {
        Ticker = alphaQuote.Symbol,
        LastPrice = price,
        BidPrice = bidPrice,
        BidSize = 1000,
        AskPrice = askPrice,
        AskSize = 500,
        LastUpdated = DateTime.Parse(alphaQuote.LatestTradingDay)
      };
      return quote;
    }
    return null;
  }
}
