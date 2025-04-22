using System;
using Microsoft.EntityFrameworkCore;
using TradingAppC.model;

namespace TradingAppC.data;

public class TradingAppCDbContext : DbContext
{
  public DbSet<Quote> Quotes { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    // base.OnConfiguring(optionsBuilder);
    optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=TradingAppC;"
    + "UserId=catalinagalan;Password=merlino");
  }
}
