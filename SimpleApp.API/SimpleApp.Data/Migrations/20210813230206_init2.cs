using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleApp.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Goscie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Imie", "Miasto", "Nazwisko" },
                values: new object[] { "daniel.danielowski@gmail.com", "Daniel", "Wrocław", "Danielowski" });

            migrationBuilder.UpdateData(
                table: "Rezerwacje",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUtworzenia", "DataWymeldowania", "DataZameldowania" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 2, 5, 976, DateTimeKind.Local).AddTicks(9006), new DateTime(2021, 8, 14, 1, 2, 5, 979, DateTimeKind.Local).AddTicks(3492), new DateTime(2021, 8, 14, 1, 2, 5, 979, DateTimeKind.Local).AddTicks(3204) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Goscie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Imie", "Miasto", "Nazwisko" },
                values: new object[] { "piotr.piotrowski@gmail.com", "Piotr", "Gliwice", "Piotrowski" });

            migrationBuilder.UpdateData(
                table: "Rezerwacje",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUtworzenia", "DataWymeldowania", "DataZameldowania" },
                values: new object[] { new DateTime(2021, 8, 13, 16, 53, 50, 844, DateTimeKind.Local).AddTicks(3062), new DateTime(2021, 8, 13, 16, 53, 50, 846, DateTimeKind.Local).AddTicks(6886), new DateTime(2021, 8, 13, 16, 53, 50, 846, DateTimeKind.Local).AddTicks(5874) });
        }
    }
}
