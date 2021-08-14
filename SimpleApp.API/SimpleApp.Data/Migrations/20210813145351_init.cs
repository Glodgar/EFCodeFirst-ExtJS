using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleApp.Data.Migrations
{
    public partial class init : Migration
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
                    KodPocztowy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "Goscie",
                columns: new[] { "Id", "Adres", "DataUrodzenia", "Email", "Imie", "KodPocztowy", "Miasto", "Nazwisko", "Telefon" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam.adamowski@gmail.com", "Adam", null, null, "Adamowski", null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "piotr.piotrowski@gmail.com", "Piotr", null, "Wrocław", "Piotrowski", null },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "piotr.piotrowski@gmail.com", "Piotr", null, null, "Piotrowski", null },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "piotr.piotrowski@gmail.com", "Piotr", null, "Gliwice", "Piotrowski", null }
                });

            migrationBuilder.InsertData(
                table: "Rezerwacje",
                columns: new[] { "Id", "Cena", "DataUtworzenia", "DataWymeldowania", "DataZameldowania", "KodRezerwacji", "Prowizja", "Waluta", "Zrodlo" },
                values: new object[] { 1, 120f, new DateTime(2021, 8, 13, 16, 53, 50, 844, DateTimeKind.Local).AddTicks(3062), new DateTime(2021, 8, 13, 16, 53, 50, 846, DateTimeKind.Local).AddTicks(6886), new DateTime(2021, 8, 13, 16, 53, 50, 846, DateTimeKind.Local).AddTicks(5874), 1, 0f, "PLN", null });

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
