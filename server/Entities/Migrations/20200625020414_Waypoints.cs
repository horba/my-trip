﻿using System;
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
                    IsDetails = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "WaypointFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaypointId = table.Column<int>(nullable: false),
                    UserFileName = table.Column<string>(nullable: true),
                    ActualFileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaypointFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaypointFiles_Waypoints_WaypointId",
                        column: x => x.WaypointId,
                        principalTable: "Waypoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Waypoints",
                columns: new[] { "Id", "ArrivalDate", "City", "DepartureDate", "Details", "ImageUrl", "IsCompleted", "IsDetails", "Order", "PathLength", "PathTime", "Transport", "TripId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 15, 1, 0, 0, 0, DateTimeKind.Unspecified), "0CitY0", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", true, true, 0, 43, new TimeSpan(0, 2, 0, 0, 0), 0, 1 },
                    { 10, new DateTime(2021, 10, 24, 2, 45, 0, 0, DateTimeKind.Unspecified), "9CitY9", new DateTime(2021, 10, 10, 0, 27, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", false, true, 9, 745, new TimeSpan(0, 11, 6, 0, 0), 4, -1 },
                    { 8, new DateTime(2021, 8, 22, 4, 35, 0, 0, DateTimeKind.Unspecified), "7CitY7", new DateTime(2021, 8, 8, 1, 21, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", false, false, 7, 589, new TimeSpan(0, 9, 38, 0, 0), 2, -1 },
                    { 7, new DateTime(2021, 7, 21, 3, 30, 0, 0, DateTimeKind.Unspecified), "6CitY6", new DateTime(2021, 7, 7, 0, 18, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", true, true, 6, 511, new TimeSpan(0, 8, 24, 0, 0), 1, -1 },
                    { 6, new DateTime(2021, 6, 20, 2, 25, 0, 0, DateTimeKind.Unspecified), "5CitY5", new DateTime(2021, 6, 6, 2, 15, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", false, false, 5, 433, new TimeSpan(0, 7, 10, 0, 0), 0, -1 },
                    { 9, new DateTime(2021, 9, 23, 1, 40, 0, 0, DateTimeKind.Unspecified), "8CitY8", new DateTime(2021, 9, 9, 2, 24, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", true, false, 8, 667, new TimeSpan(0, 10, 52, 0, 0), 3, -1 },
                    { 4, new DateTime(2021, 4, 18, 4, 15, 0, 0, DateTimeKind.Unspecified), "3CitY3", new DateTime(2021, 4, 4, 0, 9, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", false, true, 3, 277, new TimeSpan(0, 5, 42, 0, 0), 3, 1 },
                    { 3, new DateTime(2021, 3, 17, 3, 10, 0, 0, DateTimeKind.Unspecified), "2CitY2", new DateTime(2021, 3, 3, 2, 6, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", true, false, 2, 199, new TimeSpan(0, 4, 28, 0, 0), 2, 1 },
                    { 2, new DateTime(2021, 2, 16, 2, 5, 0, 0, DateTimeKind.Unspecified), "1CitY1", new DateTime(2021, 2, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", false, false, 1, 121, new TimeSpan(0, 3, 14, 0, 0), 1, 1 },
                    { 5, new DateTime(2021, 5, 19, 1, 20, 0, 0, DateTimeKind.Unspecified), "4CitY4", new DateTime(2021, 5, 5, 1, 12, 0, 0, DateTimeKind.Unspecified), "Купить зарядку для телефона", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", true, false, 4, 355, new TimeSpan(0, 6, 56, 0, 0), 4, 1 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_WaypointFiles_WaypointId",
                table: "WaypointFiles",
                column: "WaypointId");

            migrationBuilder.CreateIndex(
                name: "IX_Waypoints_TripId",
                table: "Waypoints",
                column: "TripId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WaypointFiles");

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
