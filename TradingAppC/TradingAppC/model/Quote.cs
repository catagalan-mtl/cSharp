using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;

namespace TradingAppC.model;

public class Quote
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.None)]
  public required string Ticker { get; set; }
  public float LastPrice { get; set; }
  public float BidPrice { get; set; }
  public int BidSize { get; set; }
  public float AskPrice { get; set; }
  public int AskSize { get; set; }
  public required DateTime LastUpdated { get; set; }
}
