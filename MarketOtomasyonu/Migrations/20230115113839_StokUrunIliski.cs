using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class StokUrunIliski : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_stoklar_urunler_UrunId",
                table: "stoklar",
                column: "UrunId",
                principalTable: "urunler",
                principalColumn: "UrunId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stoklar_urunler_UrunId",
                table: "stoklar");
        }
    }
}
