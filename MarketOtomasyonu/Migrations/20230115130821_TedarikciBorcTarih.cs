using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class TedarikciBorcTarih : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "tedarikciBorclar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "tedarikciBorclar");
        }
    }
}
