using System;
using System.Text.Json.Serialization;

namespace TradingAppC.model;

public class AlphaQuote
{
  [property: JsonPropertyName("01. symbol")]
  public string Symbol { get; set; }

  [property: JsonPropertyName("02. open")]
  public string Open { get; set; }

  [property: JsonPropertyName("03. high")]
  public string High { get; set; }

  [property: JsonPropertyName("04. low")]
  public string Low { get; set; }

  [property: JsonPropertyName("05. price")]
  public string Price { get; set; }

  [property: JsonPropertyName("06. volume")]
  public string Volume { get; set; }

  [property: JsonPropertyName("07. lastest trading day")]
  public string LatestTradingDay { get; set; }

  [property: JsonPropertyName("08. previous close")]
  public string PreviousClose { get; set; }

  [property: JsonPropertyName("09. change")]
  public string Change { get; set; }

  [property: JsonPropertyName("10. change percent")]
  public string ChangePercent { get; set; }


}
