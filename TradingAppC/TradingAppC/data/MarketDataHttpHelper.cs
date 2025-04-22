using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using TradingAppC.model;

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

  public async Task<AlphaQuote?> CreateAlphaQuote()
  {
    string jsonAlphaQuote = await GetJsonAlphaQuote();
    try
    {
      var responseBody = JsonNode.Parse(jsonAlphaQuote);
      Console.WriteLine(responseBody);
      var alphaQuote = JsonSerializer.Deserialize<AlphaQuote>(responseBody["Global Quote"]);
      return alphaQuote;
    }
    catch (System.Exception e)
    {
      throw new Exception(e.Message);
    }
  }

  public async Task<string> GetJsonAlphaQuote()
  {
    HttpClient client = new HttpClient();
    client.DefaultRequestHeaders.Accept.Clear();

    try
    {
      var response = await client.GetAsync(_url);
      response.EnsureSuccessStatusCode();
      string responseBody = await response.Content.ReadAsStringAsync();
      return responseBody;
    }
    catch (HttpRequestException e)
    {
      Console.WriteLine("\nException Caught:");
      Console.WriteLine(e.Message);
    }
    return "";
  }

  private static string UrlBuilderHelper(string symbol, string apiKey)
  {
    string url = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol="
                + symbol + "&apikey=" + apiKey;
    return url;
  }
}
