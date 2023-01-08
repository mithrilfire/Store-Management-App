using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class AddYoneticiToPersonel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Yonetici",
                table: "personeller",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yonetici",
                table: "personeller");
        }
    }
}
