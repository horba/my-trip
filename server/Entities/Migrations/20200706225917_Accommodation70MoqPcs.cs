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
                table: "accommodations",
                columns: new[] { "Id", "Address", "ArrivalDateTime", "CountryId", "Currency", "DepartureDateTime", "GuestCount", "Link", "Name", "Note", "Photos", "Price", "Rating", "RatingTotal", "RoomsCount", "UserId" },
                values: new object[,]
                {
                    { -1, "Moq address #30003", new DateTime(2022, 6, 17, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(2392), 2, "USD", new DateTime(2022, 6, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(2392), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #26747", "056 790 1441", null, 3500m, null, null, 1, -1 },
                    { -52, "Moq address #23698", new DateTime(2021, 10, 15, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6609), 6, "USD", new DateTime(2021, 10, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6609), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #65077", "056 790 1441", null, 1850m, null, null, 4, -1 },
                    { -51, "Moq address #87802", new DateTime(2022, 10, 14, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6603), 7, "USD", new DateTime(2022, 10, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6603), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #71147", "056 790 1441", null, 1850m, null, null, 1, -1 },
                    { -50, "Moq address #62907", new DateTime(2022, 4, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6597), 7, "USD", new DateTime(2022, 4, 6, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6597), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #29808", "056 790 1441", null, 1250m, null, null, 1, -1 },
                    { -49, "Moq address #23518", new DateTime(2022, 2, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6591), 1, "USD", new DateTime(2022, 2, 23, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6591), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #61465", "056 790 1441", null, 2950m, null, null, 4, -1 },
                    { -48, "Moq address #78702", new DateTime(2020, 12, 17, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6585), 3, "USD", new DateTime(2020, 12, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6585), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #98060", "056 790 1441", null, 4950m, null, null, 4, -1 },
                    { -47, "Moq address #76634", new DateTime(2022, 12, 1, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6579), 6, "USD", new DateTime(2022, 12, 2, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6579), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #54427", "056 790 1441", null, 3100m, null, null, 3, -1 },
                    { -53, "Moq address #84202", new DateTime(2021, 2, 11, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6615), 8, "USD", new DateTime(2021, 2, 13, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6615), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #43115", "056 790 1441", null, 1000m, null, null, 2, -1 },
                    { -45, "Moq address #66124", new DateTime(2021, 10, 11, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6525), 8, "USD", new DateTime(2021, 10, 13, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6525), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #16765", "056 790 1441", null, 2750m, null, null, 3, -1 },
                    { -43, "Moq address #75746", new DateTime(2022, 9, 23, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6512), 6, "USD", new DateTime(2022, 9, 25, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6512), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #26122", "056 790 1441", null, 4650m, null, null, 1, -1 },
                    { -42, "Moq address #25545", new DateTime(2022, 4, 2, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6506), 6, "USD", new DateTime(2022, 4, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6506), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #53709", "056 790 1441", null, 2650m, null, null, 3, -1 },
                    { -41, "Moq address #86482", new DateTime(2022, 4, 3, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6500), 3, "USD", new DateTime(2022, 4, 7, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6500), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #17437", "056 790 1441", null, 950m, null, null, 4, -1 },
                    { -40, "Moq address #92541", new DateTime(2021, 2, 5, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6494), 4, "USD", new DateTime(2021, 2, 7, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6494), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #46018", "056 790 1441", null, 2000m, null, null, 3, -1 },
                    { -39, "Moq address #40414", new DateTime(2022, 9, 10, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6488), 6, "USD", new DateTime(2022, 9, 14, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6488), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #71245", "056 790 1441", null, 600m, null, null, 3, -1 },
                    { -38, "Moq address #88712", new DateTime(2021, 4, 22, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6482), 6, "USD", new DateTime(2021, 4, 25, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6482), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #87233", "056 790 1441", null, 2700m, null, null, 4, -1 },
                    { -44, "Moq address #49027", new DateTime(2022, 8, 16, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6519), 6, "USD", new DateTime(2022, 8, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6519), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #41339", "056 790 1441", null, 4500m, null, null, 2, -1 },
                    { -37, "Moq address #52287", new DateTime(2021, 6, 28, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6476), 7, "USD", new DateTime(2021, 6, 29, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6476), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #89439", "056 790 1441", null, 1100m, null, null, 3, -1 },
                    { -54, "Moq address #23780", new DateTime(2022, 12, 29, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6621), 8, "USD", new DateTime(2022, 12, 30, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6621), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #98797", "056 790 1441", null, 1650m, null, null, 1, -1 },
                    { -56, "Moq address #79800", new DateTime(2021, 1, 30, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6634), 7, "USD", new DateTime(2021, 2, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6634), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #93046", "056 790 1441", null, 2600m, null, null, 2, -1 },
                    { -70, "Moq address #91458", new DateTime(2021, 10, 13, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6747), 1, "USD", new DateTime(2021, 10, 17, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6747), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #64491", "056 790 1441", null, 1750m, null, null, 3, -1 },
                    { -69, "Moq address #70336", new DateTime(2022, 6, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6740), 2, "USD", new DateTime(2022, 6, 8, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6740), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #41520", "056 790 1441", null, 400m, null, null, 3, -1 },
                    { -68, "Moq address #43471", new DateTime(2021, 3, 14, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6734), 3, "USD", new DateTime(2021, 3, 15, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6734), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #92232", "056 790 1441", null, 2550m, null, null, 4, -1 },
                    { -67, "Moq address #49044", new DateTime(2021, 6, 27, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6728), 3, "USD", new DateTime(2021, 7, 2, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6728), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #67032", "056 790 1441", null, 2300m, null, null, 3, -1 },
                    { -66, "Moq address #43552", new DateTime(2021, 10, 9, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6696), 3, "USD", new DateTime(2021, 10, 14, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6696), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #20005", "056 790 1441", null, 4700m, null, null, 4, -1 },
                    { -65, "Moq address #81670", new DateTime(2020, 8, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6689), 8, "USD", new DateTime(2020, 8, 23, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6689), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #54280", "056 790 1441", null, 3950m, null, null, 2, -1 },
                    { -55, "Moq address #91322", new DateTime(2022, 7, 10, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6627), 4, "USD", new DateTime(2022, 7, 16, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6627), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #32583", "056 790 1441", null, 800m, null, null, 1, -1 },
                    { -64, "Moq address #32636", new DateTime(2023, 1, 31, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6682), 1, "USD", new DateTime(2023, 2, 5, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6682), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #35167", "056 790 1441", null, 3900m, null, null, 2, -1 },
                    { -62, "Moq address #65336", new DateTime(2022, 4, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6670), 8, "USD", new DateTime(2022, 4, 21, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6670), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #52684", "056 790 1441", null, 1950m, null, null, 4, -1 },
                    { -61, "Moq address #95029", new DateTime(2021, 10, 20, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6664), 3, "USD", new DateTime(2021, 10, 22, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6664), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #32775", "056 790 1441", null, 50m, null, null, 2, -1 },
                    { -60, "Moq address #37366", new DateTime(2021, 2, 10, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6658), 4, "USD", new DateTime(2021, 2, 14, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6658), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #76388", "056 790 1441", null, 2750m, null, null, 2, -1 },
                    { -59, "Moq address #41778", new DateTime(2021, 4, 19, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6652), 1, "USD", new DateTime(2021, 4, 22, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6652), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #51946", "056 790 1441", null, 2800m, null, null, 2, -1 },
                    { -58, "Moq address #27825", new DateTime(2021, 11, 7, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6646), 4, "USD", new DateTime(2021, 11, 13, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6646), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #62136", "056 790 1441", null, 1800m, null, null, 1, -1 },
                    { -57, "Moq address #93875", new DateTime(2022, 11, 6, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6640), 4, "USD", new DateTime(2022, 11, 9, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6640), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #54028", "056 790 1441", null, 3050m, null, null, 2, -1 },
                    { -63, "Moq address #97241", new DateTime(2022, 1, 26, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6676), 4, "USD", new DateTime(2022, 1, 29, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6676), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #32328", "056 790 1441", null, 50m, null, null, 1, -1 },
                    { -36, "Moq address #96936", new DateTime(2021, 10, 24, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6470), 2, "USD", new DateTime(2021, 10, 30, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6470), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #40723", "056 790 1441", null, 1750m, null, null, 2, -1 },
                    { -46, "Moq address #78577", new DateTime(2021, 11, 17, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6572), 5, "USD", new DateTime(2021, 11, 22, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6572), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #28176", "056 790 1441", null, 2600m, null, null, 4, -1 },
                    { -34, "Moq address #97721", new DateTime(2022, 7, 16, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6457), 1, "USD", new DateTime(2022, 7, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6457), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #97988", "056 790 1441", null, 1600m, null, null, 1, -1 },
                    { -15, "Moq address #94280", new DateTime(2021, 8, 12, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6306), 2, "USD", new DateTime(2021, 8, 14, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6306), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #63043", "056 790 1441", null, 150m, null, null, 3, -1 },
                    { -14, "Moq address #91102", new DateTime(2022, 2, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6300), 1, "USD", new DateTime(2022, 2, 24, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6300), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #79183", "056 790 1441", null, 2150m, null, null, 3, -1 },
                    { -13, "Moq address #42228", new DateTime(2021, 5, 13, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6293), 6, "USD", new DateTime(2021, 5, 16, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6293), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #35814", "056 790 1441", null, 4350m, null, null, 3, -1 },
                    { -12, "Moq address #49176", new DateTime(2023, 3, 13, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6287), 7, "USD", new DateTime(2023, 3, 15, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6287), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #91591", "056 790 1441", null, 1950m, null, null, 1, -1 },
                    { -11, "Moq address #85920", new DateTime(2022, 3, 10, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6280), 6, "USD", new DateTime(2022, 3, 12, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6280), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #31245", "056 790 1441", null, 4300m, null, null, 4, -1 },
                    { -10, "Moq address #17274", new DateTime(2021, 6, 6, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6274), 5, "USD", new DateTime(2021, 6, 10, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6274), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #97463", "056 790 1441", null, 450m, null, null, 1, -1 },
                    { -16, "Moq address #86959", new DateTime(2021, 7, 29, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6312), 2, "USD", new DateTime(2021, 8, 1, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6312), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #25056", "056 790 1441", null, 150m, null, null, 4, -1 },
                    { -9, "Moq address #48829", new DateTime(2020, 12, 25, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6267), 4, "USD", new DateTime(2020, 12, 30, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6267), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #31122", "056 790 1441", null, 1900m, null, null, 1, -1 },
                    { -7, "Moq address #38684", new DateTime(2022, 10, 27, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6255), 3, "USD", new DateTime(2022, 10, 28, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6255), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #96973", "056 790 1441", null, 3750m, null, null, 1, -1 },
                    { -6, "Moq address #65210", new DateTime(2021, 7, 1, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6248), 5, "USD", new DateTime(2021, 7, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6248), 6, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #73473", "056 790 1441", null, 5000m, null, null, 2, -1 },
                    { -5, "Moq address #58935", new DateTime(2022, 7, 21, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6239), 5, "USD", new DateTime(2022, 7, 23, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6239), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #75419", "056 790 1441", null, 4450m, null, null, 3, -1 },
                    { -4, "Moq address #21170", new DateTime(2020, 9, 11, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6233), 6, "USD", new DateTime(2020, 9, 17, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6233), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #64468", "056 790 1441", null, 1300m, null, null, 2, -1 },
                    { -3, "Moq address #98227", new DateTime(2023, 1, 10, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6225), 6, "USD", new DateTime(2023, 1, 14, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6225), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #29383", "056 790 1441", null, 4300m, null, null, 2, -1 },
                    { -2, "Moq address #58906", new DateTime(2021, 8, 29, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6171), 3, "USD", new DateTime(2021, 9, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6171), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #47712", "056 790 1441", null, 3800m, null, null, 1, -1 },
                    { -35, "Moq address #64005", new DateTime(2023, 1, 9, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6464), 2, "USD", new DateTime(2023, 1, 11, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6464), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #85946", "056 790 1441", null, 2550m, null, null, 3, -1 },
                    { -17, "Moq address #67916", new DateTime(2022, 2, 16, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6318), 1, "USD", new DateTime(2022, 2, 21, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6318), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #85263", "056 790 1441", null, 4400m, null, null, 3, -1 },
                    { -8, "Moq address #79874", new DateTime(2021, 6, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6261), 2, "USD", new DateTime(2021, 6, 5, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6261), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #53572", "056 790 1441", null, 2000m, null, null, 3, -1 },
                    { -19, "Moq address #79908", new DateTime(2021, 11, 6, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6332), 7, "USD", new DateTime(2021, 11, 7, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6332), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #21684", "056 790 1441", null, 2500m, null, null, 2, -1 },
                    { -18, "Moq address #41229", new DateTime(2021, 7, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6325), 3, "USD", new DateTime(2021, 7, 20, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6325), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #68868", "056 790 1441", null, 750m, null, null, 4, -1 },
                    { -32, "Moq address #51672", new DateTime(2022, 11, 15, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6444), 2, "USD", new DateTime(2022, 11, 20, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6444), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #19741", "056 790 1441", null, 1600m, null, null, 3, -1 },
                    { -31, "Moq address #29396", new DateTime(2022, 1, 30, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6438), 3, "USD", new DateTime(2022, 2, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6438), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #81704", "056 790 1441", null, 3650m, null, null, 4, -1 },
                    { -30, "Moq address #58578", new DateTime(2022, 6, 27, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6432), 4, "USD", new DateTime(2022, 6, 28, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6432), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #69692", "056 790 1441", null, 1300m, null, null, 2, -1 },
                    { -29, "Moq address #72659", new DateTime(2021, 1, 16, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6425), 5, "USD", new DateTime(2021, 1, 20, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6425), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #27886", "056 790 1441", null, 4000m, null, null, 1, -1 },
                    { -28, "Moq address #88415", new DateTime(2021, 11, 3, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6419), 3, "USD", new DateTime(2021, 11, 5, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6419), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #25550", "056 790 1441", null, 4600m, null, null, 3, -1 },
                    { -27, "Moq address #97567", new DateTime(2023, 1, 13, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6413), 4, "USD", new DateTime(2023, 1, 17, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6413), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #58431", "056 790 1441", null, 3750m, null, null, 4, -1 },
                    { -33, "Moq address #71663", new DateTime(2021, 9, 29, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6450), 7, "USD", new DateTime(2021, 10, 3, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6450), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #74065", "056 790 1441", null, 2600m, null, null, 4, -1 },
                    { -20, "Moq address #57166", new DateTime(2021, 3, 29, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6338), 6, "USD", new DateTime(2021, 4, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6338), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #28922", "056 790 1441", null, 3150m, null, null, 1, -1 },
                    { -25, "Moq address #26257", new DateTime(2020, 8, 6, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6401), 6, "USD", new DateTime(2020, 8, 10, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6401), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #64436", "056 790 1441", null, 2100m, null, null, 2, -1 },
                    { -24, "Moq address #62912", new DateTime(2021, 6, 11, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6395), 3, "USD", new DateTime(2021, 6, 14, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6395), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #11939", "056 790 1441", null, 4700m, null, null, 2, -1 },
                    { -23, "Moq address #88255", new DateTime(2020, 8, 1, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6388), 2, "USD", new DateTime(2020, 8, 4, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6388), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #22540", "056 790 1441", null, 1450m, null, null, 1, -1 },
                    { -22, "Moq address #67006", new DateTime(2022, 6, 18, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6350), 4, "USD", new DateTime(2022, 6, 22, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6350), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #20975", "056 790 1441", null, 1500m, null, null, 3, -1 },
                    { -21, "Moq address #68541", new DateTime(2022, 7, 21, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6344), 6, "USD", new DateTime(2022, 7, 23, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6344), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #78784", "056 790 1441", null, 1450m, null, null, 4, -1 },
                    { -26, "Moq address #83701", new DateTime(2022, 10, 28, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6407), 5, "USD", new DateTime(2022, 10, 29, 1, 59, 16, 987, DateTimeKind.Local).AddTicks(6407), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #42841", "056 790 1441", null, 2300m, null, null, 4, -1 }
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
                values: new object[] { new DateTime(2013, 12, 7, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3728), new DateTime(2013, 11, 30, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2014, 1, 8, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3722), new DateTime(2014, 1, 1, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 9, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3715), new DateTime(2016, 2, 2, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 3, 10, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3707), new DateTime(2016, 3, 3, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 11, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3700), new DateTime(2018, 4, 4, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 5, 12, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3656), new DateTime(2018, 5, 5, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 13, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3594), new DateTime(2020, 6, 6, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 7, 14, 1, 59, 16, 976, DateTimeKind.Local).AddTicks(1487), new DateTime(2020, 7, 7, 1, 59, 16, 976, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 22, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5014), new DateTime(2020, 10, 7, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 24, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5391), new DateTime(2020, 11, 9, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 26, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5403), new DateTime(2020, 12, 11, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 28, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5413), new DateTime(2022, 1, 13, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 2, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5422), new DateTime(2022, 2, 15, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 1, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5432), new DateTime(2022, 3, 17, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 4, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 4, 19, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 5, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 5, 21, 1, 59, 16, 978, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "598WcKS5wwohoCWu//MlI7A+UNvdboPNnJzwakKerWSXvn9S2oIDU35tOGoCX625");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "I06i1qCtp4Ihek9yIQMWaYP8fmqvufNkqjj/xsZBZBdr4d/nU+5owtKqBn4tJ9DH");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "WFiOYl0jczpGVz9US7/TiCX2g3xWup/c37MgPtQbwHGKtwhGpyM1kZ+dfDovFyQm");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "1fj7paZ5EI1alMJ32mViveu+6H8IG1uYuMEmpVnq9s6luAPsAOVPkRDff2u+184x");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "79Gi/PVdtMZqcRsqP07grFY2/Q1zCF5ZshJ8YPWNLOec6/4++hD0eRGjOhSY6rLi");

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
                name: "accommodations");

            migrationBuilder.DropTable(
                name: "attachmentFileEating");

            migrationBuilder.DropTable(
                name: "scheduledPlaceToEat");

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
