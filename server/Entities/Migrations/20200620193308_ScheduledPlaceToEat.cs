using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class ScheduledPlaceToEat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "scheduledPlaceToEat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    NamePlace = table.Column<string>(maxLength: 200, nullable: false),
                    Notes = table.Column<string>(maxLength: 2000, nullable: true),
                    Link = table.Column<string>(nullable: true),
                    GooglePlaceId = table.Column<string>(maxLength: 50, nullable: true),
                    Lat = table.Column<double>(nullable: false),
                    Lng = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduledPlaceToEat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_scheduledPlaceToEat_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "attachmentFileEating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: false),
                    ScheduledPlaceToEatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachmentFileEating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_attachmentFileEating_scheduledPlaceToEat_ScheduledPlaceToEatId",
                        column: x => x.ScheduledPlaceToEatId,
                        principalTable: "scheduledPlaceToEat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "scheduledPlaceToEat",
                columns: new[] { "Id", "DateTime", "GooglePlaceId", "Lat", "Link", "Lng", "NamePlace", "Notes", "UserId" },
                values: new object[] { -1, new DateTime(2022, 1, 1, 14, 0, 0, 0, DateTimeKind.Local), "ChIJYcHoGyRawokR9rSZ9FTdFMk", 40.712114799999988, "http://www.nyc.gov/nypd", -74.001891700000016, "New York City Police Department", "Get as close to the station as possible and pray that the cops don't take you in", -1 });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 20, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3321), new DateTime(2013, 11, 13, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 21, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3278), new DateTime(2013, 12, 14, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 22, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3205), new DateTime(2016, 1, 15, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 23, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3145), new DateTime(2016, 2, 16, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 24, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3108), new DateTime(2018, 3, 17, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 25, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3010), new DateTime(2018, 4, 18, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 26, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(2026), new DateTime(2020, 5, 19, 22, 33, 5, 192, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 27, 22, 33, 5, 178, DateTimeKind.Local).AddTicks(6414), new DateTime(2020, 6, 20, 22, 33, 5, 178, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "xgNZSytqOJuOzEG8OQgJOhauksHtORIqEtqRFMbxaJeKkV0T1YZK//i/HV/zXObB");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "gHB8+u7+nfhOwzZa/uDvCQLv0eboqZUvx9jcAVmsfGGJOScC5W0BD8fpBEMRRZw2");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "5+/NqaAJLqA4xDwEZqrktdjzhQ/70rwXsH3j/jbt7frYi18iw+UsTV4t8M8VVzNM");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "J60H6XrP3UOFo46gilx2gk412OCEWRsF3cNcf9B+yl9nXPWan6Yjr4v4REanWy9j");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "7qi3+GjRERKZcf+NhbBlraou8m6+L9BN/zDkbYyao23NBzrIfqnfwFU2i6Zmsrte");

            migrationBuilder.CreateIndex(
                name: "IX_attachmentFileEating_ScheduledPlaceToEatId",
                table: "attachmentFileEating",
                column: "ScheduledPlaceToEatId");

            migrationBuilder.CreateIndex(
                name: "IX_scheduledPlaceToEat_UserId",
                table: "scheduledPlaceToEat",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attachmentFileEating");

            migrationBuilder.DropTable(
                name: "scheduledPlaceToEat");

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
