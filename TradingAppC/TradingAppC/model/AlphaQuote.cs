using System;
using System.Text.Json.Serialization;

namespace TradingAppC.model;

public class AlphaQuote
{
  [property: JsonPropertyName("01. symbol")]
  public string Symbol { get; set; }

  [property: JsonPropertyName("02. open")]

  public double Open { get; set; }

  [property: JsonPropertyName("03. high")]
  public double High { get; set; }

  [property: JsonPropertyName("04. low")]
  public double Low { get; set; }

  [property: JsonPropertyName("05. price")]
  public double Price { get; set; }

  [property: JsonPropertyName("06. volume")]
  public int Volume { get; set; }

  [property: JsonPropertyName("07. lastest trading day")]
  public DateTime LatestTradingDay { get; set; }

  [property: JsonPropertyName("08. previous close")]
  public double PreviousClose { get; set; }

  [property: JsonPropertyName("09. change")]
  public double Change { get; set; }

  [property: JsonPropertyName("10. change percent")]
  public string ChangePercent { get; set; }


}
