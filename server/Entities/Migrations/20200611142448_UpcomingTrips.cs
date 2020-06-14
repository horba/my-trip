using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class UpcomingTrips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "trips",
                columns: new[] { "Id", "ArrivalCountryId", "Currency", "DepartureCity", "DepartureCountryId", "DifferenceInTime", "EndDate", "FlightTime", "ImageUrl", "StartDate", "TotalPrice", "TransplantTime", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "1 час", new DateTime(2020, 9, 26, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9274), "0 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2020, 9, 11, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9274), 100m, "+ время пересадки", -1 },
                    { 8, 8, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "8 час", new DateTime(2023, 5, 10, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9828), "14 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2023, 4, 25, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9828), 156m, "- прямой", -1 },
                    { 7, 7, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "7 час", new DateTime(2023, 4, 7, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9820), "12 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2023, 3, 23, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9820), 142m, "+ время пересадки", -1 },
                    { 6, 6, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "6 час", new DateTime(2022, 3, 8, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9810), "10 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2022, 2, 21, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9810), 130m, "- прямой", -1 },
                    { 5, 5, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "5 час", new DateTime(2022, 2, 3, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9801), "8 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2022, 1, 19, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9801), 120m, "+ время пересадки", -1 },
                    { 4, 4, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "4 час", new DateTime(2022, 1, 1, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9791), "6 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2021, 12, 17, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9791), 112m, "- прямой", -1 },
                    { 3, 3, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "3 час", new DateTime(2020, 11, 30, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9782), "4 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2020, 11, 15, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9782), 106m, "+ время пересадки", -1 },
                    { 2, 2, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "2 час", new DateTime(2020, 10, 28, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9765), "2 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2020, 10, 13, 17, 24, 48, 339, DateTimeKind.Local).AddTicks(9765), 102m, "- прямой", -1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8);

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
