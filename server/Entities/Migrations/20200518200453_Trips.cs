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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trips");
        }
    }
}
