using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "musteriler",
                columns: table => new
                {
                    MusteriId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Adi = table.Column<string>(type: "TEXT", nullable: false),
                    Soyadi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musteriler", x => x.MusteriId);
                });

            migrationBuilder.CreateTable(
                name: "personeller",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Yonetici = table.Column<bool>(type: "INTEGER", nullable: false),
                    Adi = table.Column<string>(type: "TEXT", nullable: false),
                    Soyadi = table.Column<string>(type: "TEXT", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Sifre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personeller", x => x.PersonelId);
                });

            migrationBuilder.CreateTable(
                name: "tedarikciler",
                columns: table => new
                {
                    TedarikciId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Adi = table.Column<string>(type: "TEXT", nullable: false),
                    Adres = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tedarikciler", x => x.TedarikciId);
                });

            migrationBuilder.CreateTable(
                name: "urunler",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false),
                    Adi = table.Column<string>(type: "TEXT", nullable: false),
                    Barkod = table.Column<int>(type: "INTEGER", nullable: false),
                    BirimFiyati = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunler", x => x.UrunId);
                });

            migrationBuilder.CreateTable(
                name: "veresiyeler",
                columns: table => new
                {
                    VeresiyeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KalanBorc = table.Column<float>(type: "REAL", nullable: false),
                    SatisId = table.Column<int>(type: "INTEGER", nullable: false),
                    MusteriId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veresiyeler", x => x.VeresiyeId);
                    table.ForeignKey(
                        name: "FK_veresiyeler_musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "musteriler",
                        principalColumn: "MusteriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tedarikciBorclar",
                columns: table => new
                {
                    TedarikciBorcId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IrsaliyeNo = table.Column<int>(type: "INTEGER", nullable: false),
                    BorcTutari = table.Column<float>(type: "REAL", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TedarikciId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tedarikciBorclar", x => x.TedarikciBorcId);
                    table.ForeignKey(
                        name: "FK_tedarikciBorclar_tedarikciler_TedarikciId",
                        column: x => x.TedarikciId,
                        principalTable: "tedarikciler",
                        principalColumn: "TedarikciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stoklar",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false),
                    IrsaliyeId = table.Column<int>(type: "INTEGER", nullable: false),
                    GirdiBirimFiyati = table.Column<float>(type: "REAL", nullable: false),
                    Adet = table.Column<int>(type: "INTEGER", nullable: false),
                    TedarikciId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stoklar", x => new { x.UrunId, x.IrsaliyeId });
                    table.ForeignKey(
                        name: "FK_stoklar_tedarikciler_TedarikciId",
                        column: x => x.TedarikciId,
                        principalTable: "tedarikciler",
                        principalColumn: "TedarikciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stoklar_urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "urunler",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "satislar",
                columns: table => new
                {
                    SatisId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Barkod = table.Column<int>(type: "INTEGER", nullable: false),
                    Adet = table.Column<int>(type: "INTEGER", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tutar = table.Column<float>(type: "REAL", nullable: false),
                    VeresiyeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_satislar", x => x.SatisId);
                    table.ForeignKey(
                        name: "FK_satislar_veresiyeler_VeresiyeId",
                        column: x => x.VeresiyeId,
                        principalTable: "veresiyeler",
                        principalColumn: "VeresiyeId");
                });

            migrationBuilder.CreateTable(
                name: "veresiyeOdemeler",
                columns: table => new
                {
                    VeresiyeOdemeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OdemeTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tutar = table.Column<float>(type: "REAL", nullable: false),
                    VeresiyeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veresiyeOdemeler", x => x.VeresiyeOdemeId);
                    table.ForeignKey(
                        name: "FK_veresiyeOdemeler_veresiyeler_VeresiyeId",
                        column: x => x.VeresiyeId,
                        principalTable: "veresiyeler",
                        principalColumn: "VeresiyeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tedarikciOdemeler",
                columns: table => new
                {
                    TedarikciOdemeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OdemeTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tutar = table.Column<float>(type: "REAL", nullable: false),
                    TedarikciBorcId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tedarikciOdemeler", x => x.TedarikciOdemeId);
                    table.ForeignKey(
                        name: "FK_tedarikciOdemeler_tedarikciBorclar_TedarikciBorcId",
                        column: x => x.TedarikciBorcId,
                        principalTable: "tedarikciBorclar",
                        principalColumn: "TedarikciBorcId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_satislar_VeresiyeId",
                table: "satislar",
                column: "VeresiyeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stoklar_TedarikciId",
                table: "stoklar",
                column: "TedarikciId");

            migrationBuilder.CreateIndex(
                name: "IX_tedarikciBorclar_TedarikciId",
                table: "tedarikciBorclar",
                column: "TedarikciId");

            migrationBuilder.CreateIndex(
                name: "IX_tedarikciOdemeler_TedarikciBorcId",
                table: "tedarikciOdemeler",
                column: "TedarikciBorcId");

            migrationBuilder.CreateIndex(
                name: "IX_veresiyeler_MusteriId",
                table: "veresiyeler",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_veresiyeOdemeler_VeresiyeId",
                table: "veresiyeOdemeler",
                column: "VeresiyeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personeller");

            migrationBuilder.DropTable(
                name: "satislar");

            migrationBuilder.DropTable(
                name: "stoklar");

            migrationBuilder.DropTable(
                name: "tedarikciOdemeler");

            migrationBuilder.DropTable(
                name: "veresiyeOdemeler");

            migrationBuilder.DropTable(
                name: "urunler");

            migrationBuilder.DropTable(
                name: "tedarikciBorclar");

            migrationBuilder.DropTable(
                name: "veresiyeler");

            migrationBuilder.DropTable(
                name: "tedarikciler");

            migrationBuilder.DropTable(
                name: "musteriler");
        }
    }
}
