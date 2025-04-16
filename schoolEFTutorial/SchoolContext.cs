// using System;
using Microsoft.EntityFrameworkCore;
// using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace schoolEFTutorial;

public class SchoolContext : DbContext
{
  public DbSet<Student> Students { get; set; }
  public DbSet<Grade> Grades { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseNpgsql("Server=localhost;Port=5432;"
      + "User Id=catalinagalan;Password=merlino;Database=SchoolAppDb");
  }
}
