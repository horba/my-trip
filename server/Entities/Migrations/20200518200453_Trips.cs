using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Trips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "trips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DepartureCountryId = table.Column<int>(nullable: false),
                    DepartureCity = table.Column<string>(nullable: true),
                    ArrivalCountryId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    FlightTime = table.Column<string>(nullable: true),
                    DifferenceInTime = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trips_countries_ArrivalCountryId",
                        column: x => x.ArrivalCountryId,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trips_countries_DepartureCountryId",
                        column: x => x.DepartureCountryId,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trips_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "trips",
                columns: new[] { "Id", "ArrivalCountryId", "Currency", "DepartureCity", "DepartureCountryId", "DifferenceInTime", "EndDate", "FlightTime", "ImageUrl", "StartDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { -1, 1, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "1 час", new DateTime(2020, 5, 25, 23, 4, 52, 667, DateTimeKind.Local).AddTicks(8027), "0 часов + время пересадки", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2020, 5, 18, 23, 4, 52, 664, DateTimeKind.Local).AddTicks(4771), 100m, -1 },
                    { -2, 2, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "2 час", new DateTime(2020, 5, 24, 23, 4, 52, 668, DateTimeKind.Local).AddTicks(9707), "2 часов + время пересадки", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2020, 5, 17, 23, 4, 52, 668, DateTimeKind.Local).AddTicks(9675), 102m, -1 },
                    { -3, 3, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "3 час", new DateTime(2018, 5, 23, 23, 4, 52, 668, DateTimeKind.Local).AddTicks(9941), "4 часов + время пересадки", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2018, 5, 16, 23, 4, 52, 668, DateTimeKind.Local).AddTicks(9928), 106m, -1 },
                    { -4, 4, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "4 час", new DateTime(2018, 5, 22, 23, 4, 52, 668, DateTimeKind.Local).AddTicks(9969), "6 часов + время пересадки", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2018, 5, 15, 23, 4, 52, 668, DateTimeKind.Local).AddTicks(9962), 112m, -1 },
                    { -5, 5, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "5 час", new DateTime(2016, 5, 21, 23, 4, 52, 668, DateTimeKind.Local).AddTicks(9990), "8 часов + время пересадки", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2016, 5, 14, 23, 4, 52, 668, DateTimeKind.Local).AddTicks(9983), 120m, -1 },
                    { -6, 6, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "6 час", new DateTime(2016, 5, 20, 23, 4, 52, 669, DateTimeKind.Local).AddTicks(88), "10 часов + время пересадки", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2016, 5, 13, 23, 4, 52, 669, DateTimeKind.Local).AddTicks(79), 130m, -1 },
                    { -7, 7, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "7 час", new DateTime(2014, 5, 19, 23, 4, 52, 669, DateTimeKind.Local).AddTicks(109), "12 часов + время пересадки", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2014, 5, 12, 23, 4, 52, 669, DateTimeKind.Local).AddTicks(102), 142m, -1 },
                    { -8, 8, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "8 час", new DateTime(2014, 5, 18, 23, 4, 52, 669, DateTimeKind.Local).AddTicks(129), "14 часов + время пересадки", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2014, 5, 11, 23, 4, 52, 669, DateTimeKind.Local).AddTicks(123), 156m, -1 }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "3ZrRqHvOc+mZkjK35J4YB6KRLnrqOJuJ5a5mL8cEieG22ZJ5ngAdsPiPVMubCJ9y");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "5mgrcrdwS78STNTyyd4FotrXDJMuwZQKBIu+omYCG+m1v6zrJ76jc7o/LnMwbEHZ");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "V1QjU6XjQ4kKODFMqRqPSQHctTDuWLAT4nsp44L14EBIrncLQzO8hawcozIQYBFR");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "kWZVgA0hmrU0yCe5WKNWrzatDNnE3RfvjcBw3td2bhDC0is4gxzeuQfoDez3Uajh");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "IfBQ+WOkep6GOTjmLz+xjYXEbbl7+hJVOw+ZAr1a4xmL4HtuvV9yXIsFi4SrzVIN");

            migrationBuilder.CreateIndex(
                name: "IX_trips_ArrivalCountryId",
                table: "trips",
                column: "ArrivalCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_trips_DepartureCountryId",
                table: "trips",
                column: "DepartureCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_trips_UserId",
                table: "trips",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trips");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "LshVk5JSb49kQ7N+VOvXu680zCYlgmi7xvVqyekJ9Qn8Jk5AbR9unQ+DBLi5MJRA");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "rxQLuMKgW7rksxOkAY0t5NNFhduDuuuPmBI9W8LXky5STiZakwy49yafh9alWRfx");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "qujrA66Os5vU/VS1OhBSv0xTkzZZzyrlPfjNp+tDZp3NYWrn52n+WJ7I6awKY9v/");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "lThbqsIUV2GzTsa4g716ocuBSsaYu0QW1PIcziBBxVX4fgYjcFjokedNOzJ9KmkR");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "978egret4cJPDGQ5B/UIAPTfNob4DxDsEBZmHyxK0m705w7gZsLLM1Stle18VhwT");
        }
    }
}
