using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Entertainments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entertainments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    PlaceId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    PeopleCount = table.Column<int>(nullable: false),
                    VisitDate = table.Column<DateTime>(nullable: false),
                    LocationLat = table.Column<double>(nullable: true),
                    LocationLng = table.Column<double>(nullable: true),
                    EntertainmentFilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entertainments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 29, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(5010), new DateTime(2013, 11, 22, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 30, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4990), new DateTime(2013, 12, 23, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 31, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4966), new DateTime(2016, 1, 24, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 3, 3, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4939), new DateTime(2016, 2, 25, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 2, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4915), new DateTime(2018, 3, 26, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 5, 4, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4880), new DateTime(2018, 4, 27, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4385), new DateTime(2020, 5, 28, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 7, 6, 23, 25, 13, 410, DateTimeKind.Local).AddTicks(7351), new DateTime(2020, 6, 29, 23, 25, 13, 410, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 14, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(9330), new DateTime(2020, 9, 29, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 15, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(118), new DateTime(2020, 10, 31, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 18, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(172), new DateTime(2020, 12, 3, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 19, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(233), new DateTime(2022, 1, 4, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 21, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(265), new DateTime(2022, 2, 6, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 25, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(294), new DateTime(2022, 3, 10, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 25, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(326), new DateTime(2023, 4, 10, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 28, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 5, 13, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "j9Q8J9ev29vSutlN6nLaGlHpXJVIto0nnk2iBhNACtqI+9+OQvSZv33E2ndrrhUY");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "fmYL/i7ux820lpCxENVB00mQxMduwfGgHJlstlkQaCAszCXpE2fjSOU4ze/xuPci");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "OFtRgz0DLSLx/semwk2OR/G42Vs8XhY1R7V9Rr4aqdYSr52aoecjKeziJSTrwC8V");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "mPFmKxXAXalwYnVJmRB8GfteRwZjA4nlfX1ZL4OAjzDI0wl/IorXB//R6UmmQ3Ne");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "eH5tKui2yCkoPGjun0S0QGPu+6qmZyIHHSCZkUIZQnL+23DFuvqyvXf4DsMAFGJA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entertainments");

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 25, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6089), new DateTime(2013, 11, 18, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 26, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6082), new DateTime(2013, 12, 19, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 27, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6076), new DateTime(2016, 1, 20, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 28, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6066), new DateTime(2016, 2, 21, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 29, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6060), new DateTime(2018, 3, 22, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 30, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6045), new DateTime(2018, 4, 23, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 31, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(5895), new DateTime(2020, 5, 24, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 7, 2, 5, 4, 14, 52, DateTimeKind.Local).AddTicks(3112), new DateTime(2020, 6, 25, 5, 4, 14, 52, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 10, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(7751), new DateTime(2020, 9, 25, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 11, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8234), new DateTime(2020, 10, 27, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 14, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8254), new DateTime(2020, 11, 29, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 15, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8264), new DateTime(2021, 12, 31, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 17, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8274), new DateTime(2022, 2, 2, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 22, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8283), new DateTime(2022, 3, 7, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 21, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8293), new DateTime(2023, 4, 6, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 24, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8302), new DateTime(2023, 5, 9, 5, 4, 14, 54, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "NkV3Pcykz4fCxyH/whl3Sib3mOUjRcdeq5hNXqgBajoRNBi6jjfyo37j3cdFCWdH");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "23A7MakXq28tty4wfWJvN1we0s9TLmU1Wki5xLIaTdOoIggOnkSITxvjlt2MF7ZY");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "MKbrLGgtpXx0I8xVsLX328qeLTf3qOJrHMsu+pKLKwQqZdV/xw2t4eT0Usbefc0+");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "hyezt/32jRZIHyvgKENFUeShUIugFFmh34R5ye3JBnWSsRxijIBIl6vbMYs5gU7I");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "3LsjzeN7ieyDP/lwjRz6i7Kwnon06dyhin8XwDub/0qUqahl38+oCExIURLjB3f5");
        }
    }
}
