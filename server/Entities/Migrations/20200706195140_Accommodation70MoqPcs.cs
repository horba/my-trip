using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Accommodation70MoqPcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accommodations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DepartureDateTime = table.Column<DateTime>(nullable: false),
                    ArrivalDateTime = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    GuestCount = table.Column<int>(nullable: false),
                    RoomsCount = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Rating = table.Column<decimal>(nullable: true),
                    RatingTotal = table.Column<decimal>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    Photos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accommodations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "accommodations",
                columns: new[] { "Id", "Address", "ArrivalDateTime", "CountryId", "Currency", "DepartureDateTime", "GuestCount", "Link", "Name", "Note", "Photos", "Price", "Rating", "RatingTotal", "RoomsCount", "UserId" },
                values: new object[,]
                {
                    { -1, "Moq address #76416", new DateTime(2021, 4, 21, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(5919), 7, "USD", new DateTime(2021, 4, 24, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(5919), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #63420", "056 790 1441", null, 1200m, null, null, 3, -1 },
                    { -52, "Moq address #78321", new DateTime(2021, 1, 21, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(267), 4, "USD", new DateTime(2021, 1, 24, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(267), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #20339", "056 790 1441", null, 2000m, null, null, 3, -1 },
                    { -51, "Moq address #34744", new DateTime(2020, 11, 29, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(261), 8, "USD", new DateTime(2020, 12, 2, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(261), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #82398", "056 790 1441", null, 950m, null, null, 4, -1 },
                    { -50, "Moq address #66880", new DateTime(2022, 3, 10, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(256), 4, "USD", new DateTime(2022, 3, 14, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(256), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #73260", "056 790 1441", null, 50m, null, null, 1, -1 },
                    { -49, "Moq address #59654", new DateTime(2023, 1, 10, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(250), 7, "USD", new DateTime(2023, 1, 14, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(250), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #39772", "056 790 1441", null, 1950m, null, null, 3, -1 },
                    { -48, "Moq address #42132", new DateTime(2021, 11, 3, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(244), 4, "USD", new DateTime(2021, 11, 8, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(244), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #51939", "056 790 1441", null, 600m, null, null, 1, -1 },
                    { -47, "Moq address #47542", new DateTime(2021, 8, 12, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(238), 3, "USD", new DateTime(2021, 8, 18, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(238), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #57407", "056 790 1441", null, 4600m, null, null, 4, -1 },
                    { -53, "Moq address #67222", new DateTime(2020, 12, 13, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(273), 7, "USD", new DateTime(2020, 12, 18, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(273), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #84119", "056 790 1441", null, 4700m, null, null, 3, -1 },
                    { -45, "Moq address #95854", new DateTime(2022, 11, 8, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(226), 7, "USD", new DateTime(2022, 11, 11, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(226), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #20031", "056 790 1441", null, 4850m, null, null, 3, -1 },
                    { -43, "Moq address #39607", new DateTime(2021, 12, 2, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(214), 8, "USD", new DateTime(2021, 12, 5, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(214), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #62099", "056 790 1441", null, 3600m, null, null, 4, -1 },
                    { -42, "Moq address #48279", new DateTime(2021, 9, 4, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(209), 5, "USD", new DateTime(2021, 9, 5, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(209), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #23906", "056 790 1441", null, 2650m, null, null, 3, -1 },
                    { -41, "Moq address #42294", new DateTime(2021, 1, 26, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(202), 8, "USD", new DateTime(2021, 1, 29, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(202), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #27645", "056 790 1441", null, 250m, null, null, 2, -1 },
                    { -40, "Moq address #42819", new DateTime(2020, 9, 8, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(196), 7, "USD", new DateTime(2020, 9, 9, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(196), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #92899", "056 790 1441", null, 1500m, null, null, 1, -1 },
                    { -39, "Moq address #70870", new DateTime(2021, 3, 28, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(191), 6, "USD", new DateTime(2021, 3, 30, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(191), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #76047", "056 790 1441", null, 2650m, null, null, 1, -1 },
                    { -38, "Moq address #61383", new DateTime(2022, 9, 30, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(185), 5, "USD", new DateTime(2022, 10, 6, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(185), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #23720", "056 790 1441", null, 350m, null, null, 3, -1 },
                    { -44, "Moq address #82574", new DateTime(2021, 12, 28, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(220), 7, "USD", new DateTime(2021, 12, 29, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(220), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #27547", "056 790 1441", null, 1200m, null, null, 4, -1 },
                    { -37, "Moq address #25839", new DateTime(2020, 8, 9, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(179), 2, "USD", new DateTime(2020, 8, 15, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(179), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #15780", "056 790 1441", null, 1800m, null, null, 4, -1 },
                    { -54, "Moq address #88599", new DateTime(2020, 11, 28, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(279), 4, "USD", new DateTime(2020, 12, 3, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(279), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #14286", "056 790 1441", null, 2850m, null, null, 2, -1 },
                    { -56, "Moq address #33636", new DateTime(2020, 11, 30, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(291), 8, "USD", new DateTime(2020, 12, 3, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(291), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #71544", "056 790 1441", null, 4600m, null, null, 3, -1 },
                    { -70, "Moq address #22073", new DateTime(2021, 6, 18, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(514), 2, "USD", new DateTime(2021, 6, 19, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(514), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #87433", "056 790 1441", null, 1750m, null, null, 4, -1 },
                    { -69, "Moq address #18431", new DateTime(2020, 9, 27, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(508), 6, "USD", new DateTime(2020, 9, 30, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(508), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #55025", "056 790 1441", null, 450m, null, null, 4, -1 },
                    { -68, "Moq address #67957", new DateTime(2021, 1, 29, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(501), 4, "USD", new DateTime(2021, 2, 2, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(501), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #18681", "056 790 1441", null, 1150m, null, null, 2, -1 },
                    { -67, "Moq address #72882", new DateTime(2022, 1, 5, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(417), 6, "USD", new DateTime(2022, 1, 10, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(417), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #69607", "056 790 1441", null, 950m, null, null, 3, -1 },
                    { -66, "Moq address #83942", new DateTime(2023, 2, 26, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(411), 3, "USD", new DateTime(2023, 2, 27, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(411), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #27719", "056 790 1441", null, 3000m, null, null, 2, -1 },
                    { -65, "Moq address #28534", new DateTime(2022, 10, 23, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(403), 7, "USD", new DateTime(2022, 10, 29, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(403), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #65594", "056 790 1441", null, 550m, null, null, 2, -1 },
                    { -55, "Moq address #61203", new DateTime(2021, 10, 15, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(285), 1, "USD", new DateTime(2021, 10, 17, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(285), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #44500", "056 790 1441", null, 1500m, null, null, 4, -1 },
                    { -64, "Moq address #73091", new DateTime(2022, 1, 16, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(397), 2, "USD", new DateTime(2022, 1, 19, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(397), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #24806", "056 790 1441", null, 2500m, null, null, 1, -1 },
                    { -62, "Moq address #32972", new DateTime(2021, 10, 28, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(385), 7, "USD", new DateTime(2021, 11, 2, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(385), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #61703", "056 790 1441", null, 450m, null, null, 1, -1 },
                    { -61, "Moq address #23342", new DateTime(2020, 11, 15, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(380), 1, "USD", new DateTime(2020, 11, 19, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(380), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #82620", "056 790 1441", null, 450m, null, null, 3, -1 },
                    { -60, "Moq address #86195", new DateTime(2021, 12, 22, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(374), 5, "USD", new DateTime(2021, 12, 25, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(374), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #66882", "056 790 1441", null, 3700m, null, null, 3, -1 },
                    { -59, "Moq address #55223", new DateTime(2022, 1, 9, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(346), 3, "USD", new DateTime(2022, 1, 11, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(346), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #14638", "056 790 1441", null, 3150m, null, null, 4, -1 },
                    { -58, "Moq address #18200", new DateTime(2022, 11, 23, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(302), 8, "USD", new DateTime(2022, 11, 24, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(302), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #61685", "056 790 1441", null, 2800m, null, null, 2, -1 },
                    { -57, "Moq address #88044", new DateTime(2021, 5, 9, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(297), 6, "USD", new DateTime(2021, 5, 12, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(297), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #26429", "056 790 1441", null, 4550m, null, null, 2, -1 },
                    { -63, "Moq address #14059", new DateTime(2020, 11, 15, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(391), 4, "USD", new DateTime(2020, 11, 20, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(391), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #50137", "056 790 1441", null, 3050m, null, null, 2, -1 },
                    { -36, "Moq address #76397", new DateTime(2021, 4, 5, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(173), 5, "USD", new DateTime(2021, 4, 6, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(173), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #61942", "056 790 1441", null, 3150m, null, null, 1, -1 },
                    { -46, "Moq address #68408", new DateTime(2022, 5, 29, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(232), 3, "USD", new DateTime(2022, 5, 31, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(232), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #34819", "056 790 1441", null, 300m, null, null, 1, -1 },
                    { -34, "Moq address #51732", new DateTime(2023, 1, 21, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(132), 7, "USD", new DateTime(2023, 1, 26, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(132), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #83946", "056 790 1441", null, 3350m, null, null, 2, -1 },
                    { -15, "Moq address #56079", new DateTime(2022, 12, 14, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(16), 3, "USD", new DateTime(2022, 12, 15, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(16), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #81715", "056 790 1441", null, 4150m, null, null, 1, -1 },
                    { -14, "Moq address #34828", new DateTime(2022, 12, 20, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9997), 1, "USD", new DateTime(2022, 12, 26, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9997), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #64154", "056 790 1441", null, 4550m, null, null, 3, -1 },
                    { -13, "Moq address #59889", new DateTime(2020, 9, 3, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9990), 1, "USD", new DateTime(2020, 9, 6, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9990), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #18573", "056 790 1441", null, 2450m, null, null, 4, -1 },
                    { -12, "Moq address #17999", new DateTime(2022, 8, 27, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9953), 3, "USD", new DateTime(2022, 9, 1, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9953), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #96359", "056 790 1441", null, 1500m, null, null, 1, -1 },
                    { -11, "Moq address #33751", new DateTime(2020, 9, 28, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9947), 7, "USD", new DateTime(2020, 9, 29, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9947), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #11786", "056 790 1441", null, 4450m, null, null, 1, -1 },
                    { -10, "Moq address #54335", new DateTime(2021, 10, 9, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9941), 7, "USD", new DateTime(2021, 10, 14, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9941), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #29455", "056 790 1441", null, 150m, null, null, 4, -1 },
                    { -16, "Moq address #58684", new DateTime(2020, 8, 18, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(23), 4, "USD", new DateTime(2020, 8, 23, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(23), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #56860", "056 790 1441", null, 3700m, null, null, 1, -1 },
                    { -9, "Moq address #56607", new DateTime(2021, 6, 19, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9934), 6, "USD", new DateTime(2021, 6, 21, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9934), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #93530", "056 790 1441", null, 1500m, null, null, 4, -1 },
                    { -7, "Moq address #44418", new DateTime(2023, 1, 3, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9922), 3, "USD", new DateTime(2023, 1, 5, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9922), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #26966", "056 790 1441", null, 750m, null, null, 3, -1 },
                    { -6, "Moq address #75127", new DateTime(2022, 2, 11, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9915), 8, "USD", new DateTime(2022, 2, 15, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9915), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #49685", "056 790 1441", null, 1450m, null, null, 2, -1 },
                    { -5, "Moq address #77184", new DateTime(2021, 7, 25, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9907), 7, "USD", new DateTime(2021, 7, 27, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9907), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #93836", "056 790 1441", null, 1400m, null, null, 3, -1 },
                    { -4, "Moq address #98645", new DateTime(2020, 11, 7, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9900), 4, "USD", new DateTime(2020, 11, 8, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9900), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #42871", "056 790 1441", null, 2200m, null, null, 4, -1 },
                    { -3, "Moq address #43458", new DateTime(2020, 11, 18, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9892), 5, "USD", new DateTime(2020, 11, 19, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9892), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #76324", "056 790 1441", null, 3150m, null, null, 4, -1 },
                    { -2, "Moq address #68967", new DateTime(2021, 4, 18, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9825), 3, "USD", new DateTime(2021, 4, 20, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9825), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #80369", "056 790 1441", null, 3100m, null, null, 4, -1 },
                    { -35, "Moq address #91836", new DateTime(2022, 11, 13, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(166), 6, "USD", new DateTime(2022, 11, 16, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(166), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #80062", "056 790 1441", null, 1600m, null, null, 3, -1 },
                    { -17, "Moq address #39546", new DateTime(2023, 1, 17, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(29), 3, "USD", new DateTime(2023, 1, 20, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(29), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #51204", "056 790 1441", null, 4000m, null, null, 2, -1 },
                    { -8, "Moq address #28766", new DateTime(2023, 2, 25, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9928), 4, "USD", new DateTime(2023, 3, 1, 22, 51, 39, 744, DateTimeKind.Local).AddTicks(9928), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #92523", "056 790 1441", null, 1950m, null, null, 2, -1 },
                    { -19, "Moq address #18263", new DateTime(2020, 9, 6, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(42), 8, "USD", new DateTime(2020, 9, 8, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(42), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #75227", "056 790 1441", null, 800m, null, null, 4, -1 },
                    { -18, "Moq address #11178", new DateTime(2021, 12, 22, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(36), 1, "USD", new DateTime(2021, 12, 25, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(36), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #12989", "056 790 1441", null, 4600m, null, null, 3, -1 },
                    { -32, "Moq address #15143", new DateTime(2023, 3, 16, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(120), 1, "USD", new DateTime(2023, 3, 20, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(120), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #93500", "056 790 1441", null, 4900m, null, null, 1, -1 },
                    { -31, "Moq address #87823", new DateTime(2021, 6, 1, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(114), 4, "USD", new DateTime(2021, 6, 5, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(114), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #64417", "056 790 1441", null, 650m, null, null, 4, -1 },
                    { -30, "Moq address #30360", new DateTime(2022, 6, 14, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(108), 3, "USD", new DateTime(2022, 6, 16, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(108), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #99937", "056 790 1441", null, 1750m, null, null, 2, -1 },
                    { -29, "Moq address #17418", new DateTime(2021, 12, 24, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(102), 1, "USD", new DateTime(2021, 12, 25, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(102), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #45380", "056 790 1441", null, 850m, null, null, 3, -1 },
                    { -28, "Moq address #74302", new DateTime(2020, 10, 8, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(96), 6, "USD", new DateTime(2020, 10, 9, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(96), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #28500", "056 790 1441", null, 2350m, null, null, 1, -1 },
                    { -27, "Moq address #47737", new DateTime(2023, 1, 19, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(90), 2, "USD", new DateTime(2023, 1, 25, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(90), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #18198", "056 790 1441", null, 3450m, null, null, 3, -1 },
                    { -33, "Moq address #46615", new DateTime(2021, 5, 20, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(125), 3, "USD", new DateTime(2021, 5, 24, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(125), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #44081", "056 790 1441", null, 3950m, null, null, 1, -1 },
                    { -25, "Moq address #63452", new DateTime(2020, 9, 28, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(78), 4, "USD", new DateTime(2020, 9, 29, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(78), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #70548", "056 790 1441", null, 4550m, null, null, 3, -1 },
                    { -24, "Moq address #49582", new DateTime(2021, 5, 10, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(72), 5, "USD", new DateTime(2021, 5, 11, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(72), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #55453", "056 790 1441", null, 1450m, null, null, 2, -1 },
                    { -23, "Moq address #42626", new DateTime(2022, 3, 7, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(66), 2, "USD", new DateTime(2022, 3, 10, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(66), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #65059", "056 790 1441", null, 2250m, null, null, 3, -1 },
                    { -22, "Moq address #23058", new DateTime(2020, 7, 12, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(60), 4, "USD", new DateTime(2020, 7, 18, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(60), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #83400", "056 790 1441", null, 850m, null, null, 4, -1 },
                    { -21, "Moq address #44375", new DateTime(2022, 11, 18, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(54), 4, "USD", new DateTime(2022, 11, 21, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(54), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #58258", "056 790 1441", null, 2700m, null, null, 3, -1 },
                    { -26, "Moq address #21362", new DateTime(2021, 1, 20, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(84), 4, "USD", new DateTime(2021, 1, 21, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(84), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #80071", "056 790 1441", null, 900m, null, null, 1, -1 },
                    { -20, "Moq address #55449", new DateTime(2021, 4, 4, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(48), 6, "USD", new DateTime(2021, 4, 8, 22, 51, 39, 745, DateTimeKind.Local).AddTicks(48), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #17894", "056 790 1441", null, 4800m, null, null, 4, -1 }
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 6, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7344), new DateTime(2013, 11, 29, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2014, 1, 7, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7338), new DateTime(2013, 12, 31, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 8, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7332), new DateTime(2016, 2, 1, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 3, 9, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7323), new DateTime(2016, 3, 2, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 10, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7316), new DateTime(2018, 4, 3, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 5, 11, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7304), new DateTime(2018, 5, 4, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 12, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7201), new DateTime(2020, 6, 5, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 7, 13, 22, 51, 39, 733, DateTimeKind.Local).AddTicks(5016), new DateTime(2020, 7, 6, 22, 51, 39, 733, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 21, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(8672), new DateTime(2020, 10, 6, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 23, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9065), new DateTime(2020, 11, 8, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 25, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9076), new DateTime(2020, 12, 10, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 27, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9086), new DateTime(2022, 1, 12, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 1, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9095), new DateTime(2022, 2, 14, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 31, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9104), new DateTime(2022, 3, 16, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 3, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 4, 18, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 4, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9193), new DateTime(2023, 5, 20, 22, 51, 39, 735, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "y26x4ymuuzOWL1LDo7sGo5ohyoB0p5eQgCSoPwyoGNnw9JYr5OdE6Adj/lOsPB4b");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "4nbtF6EmR2lHQPo3lX9hHp9YfJHuX8JYU5y1HIZQ3wzD9P/LPJAXtvbHCbWd6hAx");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "LKfeLtzYrbJXT0dnvvbIKLdE02FMvc6S+hnrgPpkrOw+JhsHXKENou6ndocYvoma");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "txTcUvIX2gDyThTmArKX0hZhQc6SMOomvNmFB37T9kvLOP+x8vXjaloEtx913KYa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "XddvPbzjUY3pSp1VTati4/zSPH08E1VetQUmRePzH0sATlyCU/+RzLiHRYf666g2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accommodations");

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 29, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(5010), new DateTime(2013, 11, 22, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 30, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4990), new DateTime(2013, 12, 23, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 31, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4966), new DateTime(2016, 1, 24, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 3, 3, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4939), new DateTime(2016, 2, 25, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 2, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4915), new DateTime(2018, 3, 26, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 5, 4, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4880), new DateTime(2018, 4, 27, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4385), new DateTime(2020, 5, 28, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 7, 6, 23, 25, 13, 410, DateTimeKind.Local).AddTicks(7351), new DateTime(2020, 6, 29, 23, 25, 13, 410, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 14, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(9330), new DateTime(2020, 9, 29, 23, 25, 13, 415, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 15, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(118), new DateTime(2020, 10, 31, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 18, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(172), new DateTime(2020, 12, 3, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 19, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(233), new DateTime(2022, 1, 4, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 21, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(265), new DateTime(2022, 2, 6, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 25, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(294), new DateTime(2022, 3, 10, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 25, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(326), new DateTime(2023, 4, 10, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 28, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 5, 13, 23, 25, 13, 416, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "j9Q8J9ev29vSutlN6nLaGlHpXJVIto0nnk2iBhNACtqI+9+OQvSZv33E2ndrrhUY");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "fmYL/i7ux820lpCxENVB00mQxMduwfGgHJlstlkQaCAszCXpE2fjSOU4ze/xuPci");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "OFtRgz0DLSLx/semwk2OR/G42Vs8XhY1R7V9Rr4aqdYSr52aoecjKeziJSTrwC8V");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "mPFmKxXAXalwYnVJmRB8GfteRwZjA4nlfX1ZL4OAjzDI0wl/IorXB//R6UmmQ3Ne");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "eH5tKui2yCkoPGjun0S0QGPu+6qmZyIHHSCZkUIZQnL+23DFuvqyvXf4DsMAFGJA");
        }
    }
}
