namespace TradingAppC.data;

public class MarketDataHttpHelper
{
  // string _url;
  private string _symbol;
  private string _apiKey;
  private string? _url;

  public MarketDataHttpHelper(string symbol, string apiKey)
  {
    _symbol = symbol;
    _apiKey = apiKey;
    _url = UrlBuilderHelper(_symbol, _apiKey);
  }



  // public AlphaQuote ALphaQuoteString()
  // {
  //   AlphaQuote alphaQuote = new AlphaQuote();
  //   string json = GetJsonAlphaQuote(url);
  //   return alphaQuote;
  // }
  public async Task<string> GetJsonAlphaQuote()
  {
    HttpClient client = new HttpClient();
    client.DefaultRequestHeaders.Accept.Clear();

    var response = await client.GetAsync(_url);
    string json = await response.Content.ReadAsStringAsync();
    return json;
  }

  private static string UrlBuilderHelper(string symbol, string apiKey)
  {
    string url = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol="
                + symbol + "&apikey=" + apiKey;
    return url;
  }
}
