using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleApp.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goscie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KodPocztowy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goscie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rezerwacje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KodRezerwacji = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cena = table.Column<float>(type: "real", nullable: false),
                    DataZameldowania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataWymeldowania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Waluta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prowizja = table.Column<float>(type: "real", nullable: false),
                    Zrodlo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezerwacje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoscRezerwacja",
                columns: table => new
                {
                    GoscieId = table.Column<int>(type: "int", nullable: false),
                    RezerwacjeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoscRezerwacja", x => new { x.GoscieId, x.RezerwacjeId });
                    table.ForeignKey(
                        name: "FK_GoscRezerwacja_Goscie_GoscieId",
                        column: x => x.GoscieId,
                        principalTable: "Goscie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoscRezerwacja_Rezerwacje_RezerwacjeId",
                        column: x => x.RezerwacjeId,
                        principalTable: "Rezerwacje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoscRezerwacja_RezerwacjeId",
                table: "GoscRezerwacja",
                column: "RezerwacjeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoscRezerwacja");

            migrationBuilder.DropTable(
                name: "Goscie");

            migrationBuilder.DropTable(
                name: "Rezerwacje");
        }
    }
}
