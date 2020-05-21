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
                    TransplantTime = table.Column<string>(nullable: true),
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
                columns: new[] { "Id", "ArrivalCountryId", "Currency", "DepartureCity", "DepartureCountryId", "DifferenceInTime", "EndDate", "FlightTime", "ImageUrl", "StartDate", "TotalPrice", "TransplantTime", "UserId" },
                values: new object[,]
                {
                    { -1, 1, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "1 час", new DateTime(2020, 5, 28, 16, 23, 58, 90, DateTimeKind.Local).AddTicks(8946), "0 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2020, 5, 21, 16, 23, 58, 87, DateTimeKind.Local).AddTicks(1613), 100m, "+ время пересадки", -1 },
                    { -2, 2, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "2 час", new DateTime(2020, 5, 27, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(1770), "2 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2020, 5, 20, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(1739), 102m, "- прямой", -1 },
                    { -3, 3, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "3 час", new DateTime(2018, 5, 26, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2051), "4 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2018, 5, 19, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2038), 106m, "+ время пересадки", -1 },
                    { -4, 4, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "4 час", new DateTime(2018, 5, 25, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2081), "6 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2018, 5, 18, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2074), 112m, "- прямой", -1 },
                    { -5, 5, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "5 час", new DateTime(2016, 5, 24, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2101), "8 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2016, 5, 17, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2095), 120m, "+ время пересадки", -1 },
                    { -6, 6, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "6 час", new DateTime(2016, 5, 23, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2128), "10 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2016, 5, 16, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2121), 130m, "- прямой", -1 },
                    { -7, 7, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "7 час", new DateTime(2014, 5, 22, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2147), "12 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2014, 5, 15, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2141), 142m, "+ время пересадки", -1 },
                    { -8, 8, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "8 час", new DateTime(2014, 5, 21, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2166), "14 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2014, 5, 14, 16, 23, 58, 92, DateTimeKind.Local).AddTicks(2160), 156m, "- прямой", -1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trips");
        }
    }
}
