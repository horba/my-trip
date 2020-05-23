using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Countries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    NameUa = table.Column<string>(nullable: true),
                    NameRu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

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
                table: "countries",
                columns: new[] { "Id", "Name", "NameRu", "NameUa" },
                values: new object[,]
                {
                    { 1, "Albania", "Албания", "Албанія" },
                    { 2, "Canada", "Канада", "Канада" },
                    { 3, "Colombia", "Колумбия", "Колумбія" },
                    { 4, "Cyprus", "Кипр", "Кіпр" },
                    { 5, "Dominica", "Доминикана", "Домінікана" },
                    { 6, "Egypt", "Египет", "Єгипет" },
                    { 7, "France", "Франция", "Франція" },
                    { 8, "Ukraine", "Украина", "Україна" }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "0mAUfCTulv0boQNvFSUgiQtzLc3FG1wGvHkchR925kRovZUK9UhAllvYF6J455t9");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "dMZdpNvT1EhinX5lzeFW480T/c6TmIrP6mganFoe1Q2ZStv3mMis2URotQgTQdju");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "VtD+AUvoo+MDn1niftB1+tKndSrhLQJy4YqFPS1kj2o7MYpTd4NRVhmFYWQyOkXS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "gehSqdY1uzA6fsPpu1eSXtqKtWcmPAhcuqJmxcY0Mew7iDR0PpkYXIxm6IqP1sg/");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "OMxfso94mSMmzkDc/GlbiF/fmDHzVvgpEJZB0YgkzUUBHr17kSjYfRuvdTL+Bc3L");

            migrationBuilder.InsertData(
                table: "trips",
                columns: new[] { "Id", "ArrivalCountryId", "Currency", "DepartureCity", "DepartureCountryId", "DifferenceInTime", "EndDate", "FlightTime", "ImageUrl", "StartDate", "TotalPrice", "TransplantTime", "UserId" },
                values: new object[,]
                {
                    { -1, 1, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "1 час", new DateTime(2020, 5, 30, 11, 20, 51, 711, DateTimeKind.Local).AddTicks(2776), "0 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2020, 5, 23, 11, 20, 51, 711, DateTimeKind.Local).AddTicks(2776), 100m, "+ время пересадки", -1 },
                    { -2, 2, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "2 час", new DateTime(2020, 4, 29, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(805), "2 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2020, 4, 22, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(805), 102m, "- прямой", -1 },
                    { -3, 3, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "3 час", new DateTime(2018, 3, 28, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1104), "4 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2018, 3, 21, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1104), 106m, "+ время пересадки", -1 },
                    { -4, 4, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "4 час", new DateTime(2018, 2, 27, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1137), "6 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2018, 2, 20, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1137), 112m, "- прямой", -1 },
                    { -5, 5, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "5 час", new DateTime(2016, 1, 26, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1154), "8 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2016, 1, 19, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1154), 120m, "+ время пересадки", -1 },
                    { -6, 6, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "6 час", new DateTime(2015, 12, 25, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1177), "10 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2015, 12, 18, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1177), 130m, "- прямой", -1 },
                    { -7, 7, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "7 час", new DateTime(2013, 11, 24, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1192), "12 часов", "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg", new DateTime(2013, 11, 17, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1192), 142m, "+ время пересадки", -1 },
                    { -8, 8, "$", "Киев, Одесса с пересадкой в Дубае или Катаре", 8, "8 час", new DateTime(2013, 10, 23, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1207), "14 часов", "https://cdn.vuetifyjs.com/images/cards/plane.jpg", new DateTime(2013, 10, 16, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1207), 156m, "- прямой", -1 }
                });

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

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "QGHv9Ph5Zs4Wamckp35z1tCgyknOdWwKzslA85YfJCPvONI994pAhF12LX4gdAbt");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "nFIQsPpOx+YiLz/v0KfbDG4VSsmAiPZyf5nvpfyztO9EZqAyXfkv421amL9TymAE");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "MFUC0Wjm2iYvRI/rNJRBzQb+8/AHsN3GqLTkXj3UbPKxUwLgn3IsdNX3SplbVFHu");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "pRpBVq2mZq/sFyneP5hfP9IfXdLxwcWqFddpI3Mksa30Qv5+l76BsbLoPyTsYJsr");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "0cy6qRLzxD3QlIuWRAgJglhK4naCwK1khtMXYUrocy4R7A98IFvyJgGS0u0rQuU2");
        }
    }
}
