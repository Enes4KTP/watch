using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiziTurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiziTurAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiziTurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmTurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmTurAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmTurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dizilers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiziAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiziGorsel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiziAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiziTurId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dizilers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dizilers_DiziTurs_DiziTurId",
                        column: x => x.DiziTurId,
                        principalTable: "DiziTurs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Filmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmGorsel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmTurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmers_FilmTurs_FilmTurId",
                        column: x => x.FilmTurId,
                        principalTable: "FilmTurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yakindakilers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YakinAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YakinGorsel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YakinAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YakinTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmTurId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yakindakilers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yakindakilers_FilmTurs_FilmTurId",
                        column: x => x.FilmTurId,
                        principalTable: "FilmTurs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "YeniFilmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YFilmAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YFilmGorsel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YFilmAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YFilmLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmTurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YeniFilmers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YeniFilmers_FilmTurs_FilmTurId",
                        column: x => x.FilmTurId,
                        principalTable: "FilmTurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dizilers_DiziTurId",
                table: "Dizilers",
                column: "DiziTurId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmers_FilmTurId",
                table: "Filmers",
                column: "FilmTurId");

            migrationBuilder.CreateIndex(
                name: "IX_Yakindakilers_FilmTurId",
                table: "Yakindakilers",
                column: "FilmTurId");

            migrationBuilder.CreateIndex(
                name: "IX_YeniFilmers_FilmTurId",
                table: "YeniFilmers",
                column: "FilmTurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dizilers");

            migrationBuilder.DropTable(
                name: "Filmers");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Yakindakilers");

            migrationBuilder.DropTable(
                name: "YeniFilmers");

            migrationBuilder.DropTable(
                name: "DiziTurs");

            migrationBuilder.DropTable(
                name: "FilmTurs");
        }
    }
}
