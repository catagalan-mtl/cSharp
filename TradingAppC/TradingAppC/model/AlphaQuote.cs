using System;
using System.Text.Json.Serialization;

namespace TradingAppC.model;

public class AlphaQuote
{
  [property: JsonPropertyName("01. symbol")]
  public required string Symbol { get; set; }

  [property: JsonPropertyName("02. open")]
  public required string Open { get; set; }

  [property: JsonPropertyName("03. high")]
  public required string High { get; set; }

  [property: JsonPropertyName("04. low")]
  public required string Low { get; set; }

  [property: JsonPropertyName("05. price")]
  public required string Price { get; set; }

  [property: JsonPropertyName("06. volume")]
  public required string Volume { get; set; }

  [property: JsonPropertyName("07. latest trading day")]
  public required string LatestTradingDay { get; set; }

  [property: JsonPropertyName("08. previous close")]
  public required string PreviousClose { get; set; }

  [property: JsonPropertyName("09. change")]
  public required string Change { get; set; }

  [property: JsonPropertyName("10. change percent")]
  public required string ChangePercent { get; set; }


}
