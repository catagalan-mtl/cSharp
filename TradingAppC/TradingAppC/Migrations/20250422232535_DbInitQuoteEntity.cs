using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingAppC.Migrations
{
    /// <inheritdoc />
    public partial class DbInitQuoteEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Ticker = table.Column<string>(type: "text", nullable: false),
                    LastPrice = table.Column<float>(type: "real", nullable: false),
                    BidPrice = table.Column<float>(type: "real", nullable: false),
                    BidSize = table.Column<int>(type: "integer", nullable: false),
                    AskPrice = table.Column<float>(type: "real", nullable: false),
                    AskSize = table.Column<int>(type: "integer", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Ticker);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
