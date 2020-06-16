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
                    PriceLevel = table.Column<int>(nullable: true),
                    LocationLat = table.Column<decimal>(nullable: true),
                    LocationLng = table.Column<decimal>(nullable: true),
                    Photos = table.Column<string>(nullable: true),
                    GooglePlaceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accommodations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "accommodations",
                columns: new[] { "Id", "Address", "ArrivalDateTime", "DepartureDateTime", "GooglePlaceId", "GuestCount", "Link", "LocationLat", "LocationLng", "Name", "Note", "Photos", "PriceLevel", "Rating", "RatingTotal", "RoomsCount", "UserId" },
                values: new object[,]
                {
                    { -1, "Dmytra Yavornytskoho Avenue, 67К, Dnipro", new DateTime(2020, 6, 20, 19, 9, 41, 779, DateTimeKind.Local).AddTicks(2658), new DateTime(2020, 6, 22, 19, 9, 41, 779, DateTimeKind.Local).AddTicks(3496), null, 1, "http://www.grand-hotel-ukraine.dp.ua", null, null, "Grand Hotel Ukraine", "056 790 1441", null, null, null, null, 1, -1 },
                    { -2, "Sholom-Aleikhema Street, 4/26, Dnipro", new DateTime(2020, 6, 27, 19, 9, 41, 779, DateTimeKind.Local).AddTicks(8635), new DateTime(2020, 7, 2, 19, 9, 41, 779, DateTimeKind.Local).AddTicks(8673), null, 2, "http://menorah-center.com", null, null, "Menorah", "056 717 7000", null, null, null, null, 2, -1 }
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 15, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2322), new DateTime(2013, 11, 8, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 16, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2309), new DateTime(2013, 12, 9, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 17, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2294), new DateTime(2016, 1, 10, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 18, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2274), new DateTime(2016, 2, 11, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 19, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2258), new DateTime(2018, 3, 12, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 20, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2227), new DateTime(2018, 4, 13, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 21, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(1936), new DateTime(2020, 5, 14, 19, 9, 41, 761, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 22, 19, 9, 41, 756, DateTimeKind.Local).AddTicks(4078), new DateTime(2020, 6, 15, 19, 9, 41, 756, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "5s8yoYG+M5Zt6H6UpFvV8nRJqzd3hL9irOsrD4V6hGWEiX5VvRobMa3tM9IOTWc4");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "+KJx/EMtPDY+klpZUuGvW7MpgFbsd0J9rPBq2cCM/mYJ3SNYzoyMHTOuuX2hyoK5");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "vUE5W3xsNixsMFUFiNHBU4eRx1Gs/W9EmAGCwEHX9BgxUTFsf1j16m566rUn1D72");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "HZKwKRu4zDy9HVkhjtKzcPbE7KQ9H0mtcLGBIfA9mdKZHkH3meL1rzkRC+2IOhzj");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "GCc8EqSTrGRi0m4xzisaRuJW5LGU30L5SnviXJzW6eVxG5aVnmGShPj2vRwGAUVX");
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
