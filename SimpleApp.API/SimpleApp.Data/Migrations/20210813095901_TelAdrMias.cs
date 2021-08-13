using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleApp.Data.Migrations
{
    public partial class TelAdrMias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Goscie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Miasto",
                table: "Goscie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Goscie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Goscie",
                columns: new[] { "Id", "Adres", "DataUrodzenia", "Email", "Imie", "KodPocztowy", "Miasto", "Nazwisko", "Telefon" },
                values: new object[] { 4, "ul. Jackowska 56", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jacek.jackowski@gmail.com", "Jacek", null, "Warszawa", "Jackowski", "123 456 789" });

            migrationBuilder.UpdateData(
                table: "Rezerwacje",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUtworzenia", "DataWymeldowania", "DataZameldowania" },
                values: new object[] { new DateTime(2021, 8, 13, 11, 59, 0, 928, DateTimeKind.Local).AddTicks(5782), new DateTime(2021, 8, 13, 11, 59, 0, 930, DateTimeKind.Local).AddTicks(8467), new DateTime(2021, 8, 13, 11, 59, 0, 930, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Rezerwacje",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUtworzenia", "DataWymeldowania", "DataZameldowania" },
                values: new object[] { new DateTime(2021, 8, 13, 11, 59, 0, 931, DateTimeKind.Local).AddTicks(65), new DateTime(2021, 8, 13, 11, 59, 0, 931, DateTimeKind.Local).AddTicks(116), new DateTime(2021, 8, 13, 11, 59, 0, 931, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Rezerwacje",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataUtworzenia", "DataWymeldowania", "DataZameldowania" },
                values: new object[] { new DateTime(2021, 8, 13, 11, 59, 0, 931, DateTimeKind.Local).AddTicks(152), new DateTime(2021, 8, 13, 11, 59, 0, 931, DateTimeKind.Local).AddTicks(158), new DateTime(2021, 8, 13, 11, 59, 0, 931, DateTimeKind.Local).AddTicks(155) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goscie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Goscie");

            migrationBuilder.DropColumn(
                name: "Miasto",
                table: "Goscie");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Goscie");

            migrationBuilder.UpdateData(
                table: "Rezerwacje",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUtworzenia", "DataWymeldowania", "DataZameldowania" },
                values: new object[] { new DateTime(2021, 8, 13, 2, 13, 43, 59, DateTimeKind.Local).AddTicks(3372), new DateTime(2021, 8, 13, 2, 13, 43, 61, DateTimeKind.Local).AddTicks(6118), new DateTime(2021, 8, 13, 2, 13, 43, 61, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Rezerwacje",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUtworzenia", "DataWymeldowania", "DataZameldowania" },
                values: new object[] { new DateTime(2021, 8, 13, 2, 13, 43, 61, DateTimeKind.Local).AddTicks(7193), new DateTime(2021, 8, 13, 2, 13, 43, 61, DateTimeKind.Local).AddTicks(7230), new DateTime(2021, 8, 13, 2, 13, 43, 61, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Rezerwacje",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataUtworzenia", "DataWymeldowania", "DataZameldowania" },
                values: new object[] { new DateTime(2021, 8, 13, 2, 13, 43, 61, DateTimeKind.Local).AddTicks(7270), new DateTime(2021, 8, 13, 2, 13, 43, 61, DateTimeKind.Local).AddTicks(7275), new DateTime(2021, 8, 13, 2, 13, 43, 61, DateTimeKind.Local).AddTicks(7273) });
        }
    }
}
