using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Entertainment : Migration
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
                values: new object[] { new DateTime(2013, 11, 19, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(7031), new DateTime(2013, 11, 12, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 20, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(7013), new DateTime(2013, 12, 13, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 21, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6995), new DateTime(2016, 1, 14, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 22, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6969), new DateTime(2016, 2, 15, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 23, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6947), new DateTime(2018, 3, 16, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 24, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6917), new DateTime(2018, 4, 17, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 25, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6498), new DateTime(2020, 5, 18, 23, 47, 36, 899, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 26, 23, 47, 36, 895, DateTimeKind.Local).AddTicks(2460), new DateTime(2020, 6, 19, 23, 47, 36, 895, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "ip/5RFPRddlJ3rxtE5gydieWTtuLmdzJie2f7bnsi/ZrWQGmTToXi1NrPk9MN65J");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "aNOYDuShuwLjerCMT8bBPGSfACVc8Snv+lffOF5IObVcqchHcmKonZzo/2pCTz4S");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "hwKqDwMsjC6/T0m7YT5bPVzOShzCL2jdwZj14aLtzLBF6hYg8XgQlYmoRJ3FcVoq");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "2+3Uaa7IhkiHA3yc6P2AO7NrfnKsqHjKE7o3mGH7aK/RCnIijrGgnJlEOLegNljg");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "RMCQ3GdeWeGABRjWOyys3yo91y9PCKYJ0ZXIj0JZCYTsC8+SHVp2ovB2CWyLYRF/");
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
