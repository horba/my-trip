using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Waypoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Waypoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Departure = table.Column<DateTime>(nullable: false),
                    Arrival = table.Column<DateTime>(nullable: false),
                    PathTime = table.Column<TimeSpan>(nullable: false),
                    PathLength = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Transport = table.Column<int>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waypoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Waypoints_trips_TripId",
                        column: x => x.TripId,
                        principalTable: "trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Waypoints",
                columns: new[] { "Id", "Arrival", "City", "Departure", "Details", "IsCompleted", "Order", "PathLength", "PathTime", "Transport", "TripId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 15, 1, 0, 0, 0, DateTimeKind.Unspecified), "0CitY0", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона с нужной вилкой на 220 и 110", true, 0, 43, new TimeSpan(0, 2, 0, 0, 0), 0, 1 },
                    { 2, new DateTime(2021, 2, 16, 2, 5, 0, 0, DateTimeKind.Unspecified), "1CitY1", new DateTime(2021, 2, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона с нужной вилкой на 220 и 110", false, 1, 121, new TimeSpan(0, 3, 14, 0, 0), 1, 1 },
                    { 3, new DateTime(2021, 3, 17, 3, 10, 0, 0, DateTimeKind.Unspecified), "2CitY2", new DateTime(2021, 3, 3, 2, 6, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона с нужной вилкой на 220 и 110", true, 2, 199, new TimeSpan(0, 4, 28, 0, 0), 2, 1 },
                    { 4, new DateTime(2021, 4, 18, 4, 15, 0, 0, DateTimeKind.Unspecified), "3CitY3", new DateTime(2021, 4, 4, 0, 9, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона с нужной вилкой на 220 и 110", false, 3, 277, new TimeSpan(0, 5, 42, 0, 0), 3, 1 },
                    { 5, new DateTime(2021, 5, 19, 1, 20, 0, 0, DateTimeKind.Unspecified), "4CitY4", new DateTime(2021, 5, 5, 1, 12, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона с нужной вилкой на 220 и 110", true, 4, 355, new TimeSpan(0, 6, 56, 0, 0), 4, 1 },
                    { 6, new DateTime(2021, 6, 20, 2, 25, 0, 0, DateTimeKind.Unspecified), "5CitY5", new DateTime(2021, 6, 6, 2, 15, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона с нужной вилкой на 220 и 110", false, 5, 433, new TimeSpan(0, 7, 10, 0, 0), 0, 1 },
                    { 7, new DateTime(2021, 7, 21, 3, 30, 0, 0, DateTimeKind.Unspecified), "6CitY6", new DateTime(2021, 7, 7, 0, 18, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона с нужной вилкой на 220 и 110", true, 6, 511, new TimeSpan(0, 8, 24, 0, 0), 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 14, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1931), new DateTime(2013, 11, 7, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 15, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1924), new DateTime(2013, 12, 8, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 16, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1917), new DateTime(2016, 1, 9, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 17, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1908), new DateTime(2016, 2, 10, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 18, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1900), new DateTime(2018, 3, 11, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 19, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1846), new DateTime(2018, 4, 12, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 20, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1686), new DateTime(2020, 5, 13, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 21, 3, 8, 22, 769, DateTimeKind.Local).AddTicks(9616), new DateTime(2020, 6, 14, 3, 8, 22, 769, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 9, 29, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(3535), new DateTime(2020, 9, 14, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 31, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4104), new DateTime(2020, 10, 16, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 3, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4123), new DateTime(2020, 11, 18, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 4, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4133), new DateTime(2021, 12, 20, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 6, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4143), new DateTime(2022, 1, 22, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 11, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4152), new DateTime(2022, 2, 24, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 10, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4161), new DateTime(2023, 3, 26, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 13, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4171), new DateTime(2023, 4, 28, 3, 8, 22, 772, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "/0KytQckJRBfiSNqLbIna40/qQ0Le60xRR7kOlXgH7XR3XSTdFeY/giJCX6aXbt4");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "pejtNFgcnm2GS/0OlHfaRR5BZ6FivxfaNLz8B9T6p8fUnG1+BB5HvblQlfCEOQgw");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "dX69i6yjU6uMhYd/N0PXxC36S+Xxv+5WKvwzmmWeON36y4G9P8NDFOtQcAFsCFDm");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "m0sgyKcAoe49tp3HLmy2vXrbm9TZ2JLhxA4Dw20DS7PjgOm/aajZVjnaApsciCHZ");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "TUE84wwScLNrNAqIIntL6pM5aXdQH86I45ktdpySWW7Lks+IQ8ROMipz9/25/yyv");

            migrationBuilder.CreateIndex(
                name: "IX_Waypoints_TripId",
                table: "Waypoints",
                column: "TripId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Waypoints");

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 11, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7587), new DateTime(2013, 11, 4, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 12, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7581), new DateTime(2013, 12, 5, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 13, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7575), new DateTime(2016, 1, 6, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 14, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7566), new DateTime(2016, 2, 7, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 15, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7560), new DateTime(2018, 3, 8, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 16, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7546), new DateTime(2018, 4, 9, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 17, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7390), new DateTime(2020, 5, 10, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 18, 17, 24, 48, 337, DateTimeKind.Local).AddTicks(5333), new DateTime(2020, 6, 11, 17, 24, 48, 337, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 9, 26, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9274), new DateTime(2020, 9, 11, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 28, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9765), new DateTime(2020, 10, 13, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 30, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9782), new DateTime(2020, 11, 15, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 1, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9791), new DateTime(2021, 12, 17, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 3, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9801), new DateTime(2022, 1, 19, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 8, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9810), new DateTime(2022, 2, 21, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 7, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9820), new DateTime(2023, 3, 23, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 4, 25, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "FrfwQx7/H30x6B36O/zyxzNEgQ6r9Gh8o2jPEw56qE4x5KAzcTJ4nOwrdm5uC//A");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "E8WgcDVa4CSdbxD+yMdTcYhFKeoDOOT6J9Vr9B9seMV7ZJ5Se5JtT0RPbe1vcssk");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "0GM8hqjKdhZF47kPS85T7I2E7EQ4VtukKMMZWck7PYvmOfxH+L+cC4D1m2Cs3zxk");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "6xKXWwFqIIrqSfwQttUqF/S6/nRxyw/QRZfJ8xiht8VXgg05RkZ+cs+CxOE3bGf+");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "9LH6hqptjnk5z/B6Q6x+SkyXmYdSC7NP66nVbnrGgHN+eN8jwSPcUIQaIigDniSg");
        }
    }
}
