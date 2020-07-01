using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Accommodations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accommodations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DepartureDateTime = table.Column<DateTime>(nullable: false),
                    ArrivalDateTime = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    GuestCount = table.Column<int>(nullable: false),
                    RoomsCount = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Rating = table.Column<decimal>(nullable: true),
                    RatingTotal = table.Column<decimal>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    Photos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accommodations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "accommodations",
                columns: new[] { "Id", "Address", "ArrivalDateTime", "Currency", "DepartureDateTime", "GuestCount", "Link", "Name", "Note", "Photos", "Price", "Rating", "RatingTotal", "RoomsCount", "UserId" },
                values: new object[,]
                {
                    { -1, "Dmytra Yavornytskoho Avenue, 67К, Dnipro", new DateTime(2020, 6, 27, 12, 43, 59, 430, DateTimeKind.Local).AddTicks(1665), "USD", new DateTime(2020, 6, 29, 12, 43, 59, 430, DateTimeKind.Local).AddTicks(2445), 1, "http://www.grand-hotel-ukraine.dp.ua", "Grand Hotel Ukraine", "056 790 1441", null, 100m, null, null, 1, -1 },
                    { -2, "Sholom-Aleikhema Street, 4/26, Dnipro", new DateTime(2020, 7, 4, 12, 43, 59, 430, DateTimeKind.Local).AddTicks(9011), "USD", new DateTime(2020, 7, 9, 12, 43, 59, 430, DateTimeKind.Local).AddTicks(9049), 2, "http://menorah-center.com", "Menorah", "056 717 7000", null, 90m, null, null, 2, -1 }
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 22, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7099), new DateTime(2013, 11, 15, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 23, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7087), new DateTime(2013, 12, 16, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 24, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7073), new DateTime(2016, 1, 17, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 25, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7052), new DateTime(2016, 2, 18, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 26, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7036), new DateTime(2018, 3, 19, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 27, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7004), new DateTime(2018, 4, 20, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 28, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(6608), new DateTime(2020, 5, 21, 12, 43, 59, 412, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 29, 12, 43, 59, 408, DateTimeKind.Local).AddTicks(1869), new DateTime(2020, 6, 22, 12, 43, 59, 408, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "FvIy3eq/6UrgQ/ZgY8xPrT74v7Trv93JMUQsExW4yw2dCe+jQvJ6NpL38FT9xzQF");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "AkMyjm6WiiTT0iWKOOeeXEockb0NIuBCv0Q+68PcjIbHd9nnuxtIuh6mbxEZt6TD");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "hRy420Z1WBEHdzBH9mrSJaJCq2dnz26adbjoRur0VLs6kPDQKTrQ5NqjuZ5bp2V0");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "7qXfsOnq+O9yk+mmYfipMWNsmK3yNMTrDOOohKAud8iqhwh4DMJOc7j92PttqGjV");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "AYHMYUQfxguKGVpbF2xYsg6eI/MM3x6Y798UbFYtGfD4GO7up9CSo+AL/ktBrtgm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accommodations");

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 8, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7669), new DateTime(2013, 11, 1, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 9, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7662), new DateTime(2013, 12, 2, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 10, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7656), new DateTime(2016, 1, 3, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 11, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7647), new DateTime(2016, 2, 4, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 12, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7640), new DateTime(2018, 3, 5, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 13, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7626), new DateTime(2018, 4, 6, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 14, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7470), new DateTime(2020, 5, 7, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 15, 17, 29, 53, 533, DateTimeKind.Local).AddTicks(4943), new DateTime(2020, 6, 8, 17, 29, 53, 533, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "hSwRBu0TlyHi+eMDGMW2YM6kN6OTjsRfJ+8CBSmo8gB7utkb25zxGMmwUbA8RMUn");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "tJnHvgpNpyyyC5uhfi0qmGSFycW6VIcpQYtOtiThMs3ntJ0MEolHeOiQ63uFuV5f");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "ThMK2O3QoEUPtMjY0Q77ajQFUowh/97a4vNNGWJkyidHr1Cp3jkbDHJsNpIcGTgw");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "fZGtHLkKTSW+hAtXYZ6+1cUBMZUlHd0OR0pxoK2z493heGLrHtO8qTPw4iBae/T+");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "HeW8o1gi5/HRxNuimINBK0exhgcgueMp9gNYP9as992yG1CYCM0fwDxHKe4ZLnPA");
        }
    }
}
