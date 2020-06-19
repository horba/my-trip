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
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    PathTime = table.Column<TimeSpan>(nullable: false),
                    PathLength = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Transport = table.Column<int>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false),
                    IsDetails = table.Column<bool>(nullable: false)
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
                columns: new[] { "Id", "ArrivalDate", "City", "DepartureDate", "Details", "IsCompleted", "IsDetails", "Order", "PathLength", "PathTime", "Transport", "TripId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 15, 1, 0, 0, 0, DateTimeKind.Unspecified), "0CitY0", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", true, true, 0, 43, new TimeSpan(0, 2, 0, 0, 0), 0, 1 },
                    { 2, new DateTime(2021, 2, 16, 2, 5, 0, 0, DateTimeKind.Unspecified), "1CitY1", new DateTime(2021, 2, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", false, false, 1, 121, new TimeSpan(0, 3, 14, 0, 0), 1, 1 },
                    { 3, new DateTime(2021, 3, 17, 3, 10, 0, 0, DateTimeKind.Unspecified), "2CitY2", new DateTime(2021, 3, 3, 2, 6, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", true, false, 2, 199, new TimeSpan(0, 4, 28, 0, 0), 2, 1 },
                    { 4, new DateTime(2021, 4, 18, 4, 15, 0, 0, DateTimeKind.Unspecified), "3CitY3", new DateTime(2021, 4, 4, 0, 9, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", false, true, 3, 277, new TimeSpan(0, 5, 42, 0, 0), 3, 1 },
                    { 5, new DateTime(2021, 5, 19, 1, 20, 0, 0, DateTimeKind.Unspecified), "4CitY4", new DateTime(2021, 5, 5, 1, 12, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", true, false, 4, 355, new TimeSpan(0, 6, 56, 0, 0), 4, 1 },
                    { 6, new DateTime(2021, 6, 20, 2, 25, 0, 0, DateTimeKind.Unspecified), "5CitY5", new DateTime(2021, 6, 6, 2, 15, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", false, false, 5, 433, new TimeSpan(0, 7, 10, 0, 0), 0, 1 },
                    { 7, new DateTime(2021, 7, 21, 3, 30, 0, 0, DateTimeKind.Unspecified), "6CitY6", new DateTime(2021, 7, 7, 0, 18, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", true, true, 6, 511, new TimeSpan(0, 8, 24, 0, 0), 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 18, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9999), new DateTime(2013, 11, 11, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 19, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9992), new DateTime(2013, 12, 12, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 20, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9985), new DateTime(2016, 1, 13, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 21, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9937), new DateTime(2016, 2, 14, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 22, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9930), new DateTime(2018, 3, 15, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 23, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9918), new DateTime(2018, 4, 16, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 24, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9761), new DateTime(2020, 5, 17, 21, 18, 10, 652, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 25, 21, 18, 10, 650, DateTimeKind.Local).AddTicks(7644), new DateTime(2020, 6, 18, 21, 18, 10, 650, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 3, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(1612), new DateTime(2020, 9, 18, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 4, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2192), new DateTime(2020, 10, 20, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 7, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2211), new DateTime(2020, 11, 22, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 8, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2221), new DateTime(2021, 12, 24, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 10, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 1, 26, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 15, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2241), new DateTime(2022, 2, 28, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 14, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 3, 30, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 17, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 5, 2, 21, 18, 10, 653, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "Z/FX2z/1PaeJLquYo3/KJt97bIaJO4iBCyhKj13xOhKPbgk+0sBED9d+Uy6PUHAv");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "GO89OpZx+b3aQk00/f0mXuYqlEclMTz6rsPk6H8QnSERy0lRgaryIHF3+Tq7c9Hc");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "Y7oAxv6Keel9EJAJJWxsGDXoC5oN1+a+uGTyOM5m7UXHhiFwg9JJeIrmF7X9iBnE");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "7VfwUAdVg+k0NKgNVKOGAC3f0QrMART+LJRqg7t5Ynl2/OD2X0Vj0qlmM+uXcc6Z");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "922/GopM6mca3ZMdwcQQMvjRV90SmSN8EPRcjvJU5YTZf638aLidwNYoN6tmLxOU");

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
