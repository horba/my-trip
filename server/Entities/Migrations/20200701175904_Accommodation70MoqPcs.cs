using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Accommodation70MoqPcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Link", "Name", "Note", "Price" },
                values: new object[] { "Moq address #34378", new DateTime(2021, 1, 7, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4051), new DateTime(2021, 1, 12, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4051), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #64381", "056 790 1441", 2450m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #92139", new DateTime(2021, 2, 12, 20, 59, 4, 250, DateTimeKind.Local).AddTicks(9380), new DateTime(2021, 2, 14, 20, 59, 4, 250, DateTimeKind.Local).AddTicks(9380), 21, "Moq Hotel #74237", 250m, 4 });

            migrationBuilder.InsertData(
                table: "accommodations",
                columns: new[] { "Id", "Address", "ArrivalDateTime", "Currency", "DepartureDateTime", "GuestCount", "Link", "Name", "Note", "Photos", "Price", "Rating", "RatingTotal", "RoomsCount", "UserId" },
                values: new object[,]
                {
                    { -40, "Moq address #53097", new DateTime(2021, 2, 9, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4514), "USD", new DateTime(2021, 2, 14, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4514), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #43047", "056 790 1441", null, 1600m, null, null, 1, -1 },
                    { -41, "Moq address #62033", new DateTime(2021, 8, 6, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4520), "USD", new DateTime(2021, 8, 10, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4520), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #16057", "056 790 1441", null, 3250m, null, null, 14, -1 },
                    { -42, "Moq address #23614", new DateTime(2021, 9, 29, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4526), "USD", new DateTime(2021, 10, 3, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4526), 14, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #10210", "056 790 1441", null, 2950m, null, null, 3, -1 },
                    { -43, "Moq address #84785", new DateTime(2021, 10, 19, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4532), "USD", new DateTime(2021, 10, 21, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4532), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #82977", "056 790 1441", null, 1250m, null, null, 10, -1 },
                    { -44, "Moq address #53847", new DateTime(2023, 2, 11, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4538), "USD", new DateTime(2023, 2, 16, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4538), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #60765", "056 790 1441", null, 4750m, null, null, 3, -1 },
                    { -45, "Moq address #23622", new DateTime(2022, 10, 19, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4544), "USD", new DateTime(2022, 10, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4544), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #90155", "056 790 1441", null, 3650m, null, null, 13, -1 },
                    { -46, "Moq address #91433", new DateTime(2023, 1, 18, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4579), "USD", new DateTime(2023, 1, 20, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4579), 26, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #35688", "056 790 1441", null, 4200m, null, null, 12, -1 },
                    { -47, "Moq address #53502", new DateTime(2022, 3, 2, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4585), "USD", new DateTime(2022, 3, 8, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4585), 22, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #72327", "056 790 1441", null, 3700m, null, null, 2, -1 },
                    { -49, "Moq address #14400", new DateTime(2021, 11, 18, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4597), "USD", new DateTime(2021, 11, 19, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4597), 21, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #89249", "056 790 1441", null, 3050m, null, null, 11, -1 },
                    { -50, "Moq address #50141", new DateTime(2020, 10, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4603), "USD", new DateTime(2020, 10, 31, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4603), 11, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #74221", "056 790 1441", null, 2700m, null, null, 13, -1 },
                    { -51, "Moq address #46412", new DateTime(2021, 12, 10, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4609), "USD", new DateTime(2021, 12, 16, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4609), 26, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #13996", "056 790 1441", null, 1750m, null, null, 6, -1 },
                    { -52, "Moq address #40049", new DateTime(2022, 11, 20, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4615), "USD", new DateTime(2022, 11, 21, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4615), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #79948", "056 790 1441", null, 1450m, null, null, 3, -1 },
                    { -53, "Moq address #63068", new DateTime(2021, 8, 26, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4621), "USD", new DateTime(2021, 8, 27, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4621), 23, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #29507", "056 790 1441", null, 2150m, null, null, 4, -1 },
                    { -54, "Moq address #24818", new DateTime(2021, 8, 12, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4627), "USD", new DateTime(2021, 8, 18, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4627), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #27700", "056 790 1441", null, 2500m, null, null, 3, -1 },
                    { -55, "Moq address #40927", new DateTime(2023, 3, 7, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4633), "USD", new DateTime(2023, 3, 8, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4633), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #91944", "056 790 1441", null, 200m, null, null, 3, -1 },
                    { -56, "Moq address #62058", new DateTime(2021, 9, 4, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4639), "USD", new DateTime(2021, 9, 8, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4639), 20, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #74959", "056 790 1441", null, 3150m, null, null, 1, -1 },
                    { -70, "Moq address #84328", new DateTime(2021, 8, 24, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4747), "USD", new DateTime(2021, 8, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4747), 3, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #69065", "056 790 1441", null, 4100m, null, null, 7, -1 },
                    { -69, "Moq address #95267", new DateTime(2021, 2, 28, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4741), "USD", new DateTime(2021, 3, 4, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4741), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #29901", "056 790 1441", null, 4900m, null, null, 1, -1 },
                    { -68, "Moq address #92237", new DateTime(2022, 8, 26, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4735), "USD", new DateTime(2022, 8, 27, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4735), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #33423", "056 790 1441", null, 4200m, null, null, 6, -1 },
                    { -67, "Moq address #33821", new DateTime(2023, 1, 16, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4705), "USD", new DateTime(2023, 1, 18, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4705), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #74044", "056 790 1441", null, 3950m, null, null, 6, -1 },
                    { -66, "Moq address #45084", new DateTime(2021, 3, 15, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4699), "USD", new DateTime(2021, 3, 19, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4699), 9, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #86064", "056 790 1441", null, 3700m, null, null, 13, -1 },
                    { -65, "Moq address #53719", new DateTime(2020, 11, 3, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4692), "USD", new DateTime(2020, 11, 9, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4692), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #75227", "056 790 1441", null, 50m, null, null, 11, -1 },
                    { -39, "Moq address #15551", new DateTime(2021, 4, 29, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4508), "USD", new DateTime(2021, 5, 1, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4508), 29, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #64850", "056 790 1441", null, 3700m, null, null, 15, -1 },
                    { -64, "Moq address #55231", new DateTime(2022, 4, 15, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4686), "USD", new DateTime(2022, 4, 20, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4686), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #40837", "056 790 1441", null, 1200m, null, null, 11, -1 },
                    { -62, "Moq address #62710", new DateTime(2020, 10, 22, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4674), "USD", new DateTime(2020, 10, 26, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4674), 28, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #22681", "056 790 1441", null, 2400m, null, null, 12, -1 },
                    { -61, "Moq address #19112", new DateTime(2021, 11, 10, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4668), "USD", new DateTime(2021, 11, 11, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4668), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #62349", "056 790 1441", null, 1500m, null, null, 12, -1 },
                    { -60, "Moq address #78787", new DateTime(2022, 11, 15, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4662), "USD", new DateTime(2022, 11, 21, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4662), 0, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #96984", "056 790 1441", null, 4950m, null, null, 4, -1 },
                    { -59, "Moq address #80950", new DateTime(2022, 10, 27, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4656), "USD", new DateTime(2022, 10, 29, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4656), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #16319", "056 790 1441", null, 4450m, null, null, 13, -1 },
                    { -58, "Moq address #65227", new DateTime(2021, 11, 12, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4650), "USD", new DateTime(2021, 11, 18, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4650), 17, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #85211", "056 790 1441", null, 600m, null, null, 1, -1 },
                    { -57, "Moq address #67270", new DateTime(2020, 10, 16, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4645), "USD", new DateTime(2020, 10, 21, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4645), 15, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #17840", "056 790 1441", null, 3450m, null, null, 5, -1 },
                    { -63, "Moq address #73503", new DateTime(2020, 9, 18, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4680), "USD", new DateTime(2020, 9, 23, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4680), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #26286", "056 790 1441", null, 2900m, null, null, 14, -1 },
                    { -38, "Moq address #87920", new DateTime(2020, 11, 8, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4502), "USD", new DateTime(2020, 11, 14, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4502), 0, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #99856", "056 790 1441", null, 2150m, null, null, 11, -1 },
                    { -48, "Moq address #98842", new DateTime(2022, 1, 10, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4591), "USD", new DateTime(2022, 1, 14, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4591), 13, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #52490", "056 790 1441", null, 2200m, null, null, 1, -1 },
                    { -36, "Moq address #77436", new DateTime(2022, 1, 1, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4490), "USD", new DateTime(2022, 1, 7, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4490), 13, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #60827", "056 790 1441", null, 4650m, null, null, 0, -1 },
                    { -17, "Moq address #46566", new DateTime(2020, 10, 16, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4284), "USD", new DateTime(2020, 10, 21, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4284), 22, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #80081", "056 790 1441", null, 2300m, null, null, 12, -1 },
                    { -16, "Moq address #33738", new DateTime(2020, 8, 19, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4277), "USD", new DateTime(2020, 8, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4277), 16, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #65214", "056 790 1441", null, 4900m, null, null, 1, -1 },
                    { -15, "Moq address #87456", new DateTime(2021, 5, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4272), "USD", new DateTime(2021, 5, 29, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4272), 27, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #69797", "056 790 1441", null, 1750m, null, null, 5, -1 },
                    { -14, "Moq address #39732", new DateTime(2021, 11, 21, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4254), "USD", new DateTime(2021, 11, 22, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4254), 17, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #58365", "056 790 1441", null, 1950m, null, null, 10, -1 },
                    { -13, "Moq address #27182", new DateTime(2021, 10, 16, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4247), "USD", new DateTime(2021, 10, 20, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4247), 20, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #79206", "056 790 1441", null, 4900m, null, null, 14, -1 },
                    { -12, "Moq address #30176", new DateTime(2023, 3, 12, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4242), "USD", new DateTime(2023, 3, 18, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4242), 14, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #99083", "056 790 1441", null, 2400m, null, null, 2, -1 },
                    { -18, "Moq address #10323", new DateTime(2022, 4, 28, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4291), "USD", new DateTime(2022, 5, 2, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4291), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #89713", "056 790 1441", null, 2850m, null, null, 9, -1 },
                    { -11, "Moq address #15579", new DateTime(2020, 9, 21, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4235), "USD", new DateTime(2020, 9, 27, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4235), 23, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #24475", "056 790 1441", null, 2000m, null, null, 5, -1 },
                    { -37, "Moq address #40917", new DateTime(2020, 12, 26, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4496), "USD", new DateTime(2020, 12, 31, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4496), 12, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #28611", "056 790 1441", null, 850m, null, null, 1, -1 },
                    { -8, "Moq address #15405", new DateTime(2021, 9, 1, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4217), "USD", new DateTime(2021, 9, 5, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4217), 1, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #28461", "056 790 1441", null, 2550m, null, null, 13, -1 },
                    { -7, "Moq address #45402", new DateTime(2021, 5, 13, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4211), "USD", new DateTime(2021, 5, 15, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4211), 16, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #78360", "056 790 1441", null, 4700m, null, null, 15, -1 },
                    { -6, "Moq address #19610", new DateTime(2023, 2, 5, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4204), "USD", new DateTime(2023, 2, 7, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4204), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #63904", "056 790 1441", null, 4650m, null, null, 7, -1 },
                    { -5, "Moq address #75035", new DateTime(2022, 12, 22, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4195), "USD", new DateTime(2022, 12, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4195), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #70791", "056 790 1441", null, 2050m, null, null, 8, -1 },
                    { -4, "Moq address #33729", new DateTime(2022, 6, 15, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4189), "USD", new DateTime(2022, 6, 17, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4189), 22, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #76992", "056 790 1441", null, 650m, null, null, 6, -1 },
                    { -10, "Moq address #83220", new DateTime(2023, 1, 16, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4229), "USD", new DateTime(2023, 1, 20, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4229), 20, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #49060", "056 790 1441", null, 2850m, null, null, 1, -1 },
                    { -19, "Moq address #28157", new DateTime(2022, 3, 18, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4297), "USD", new DateTime(2022, 3, 23, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4297), 21, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #85012", "056 790 1441", null, 3300m, null, null, 0, -1 },
                    { -9, "Moq address #96588", new DateTime(2023, 2, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4222), "USD", new DateTime(2023, 3, 1, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4222), 26, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #18380", "056 790 1441", null, 1450m, null, null, 14, -1 },
                    { -21, "Moq address #19499", new DateTime(2020, 12, 7, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4309), "USD", new DateTime(2020, 12, 13, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4309), 24, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #69803", "056 790 1441", null, 2000m, null, null, 15, -1 },
                    { -20, "Moq address #61456", new DateTime(2021, 5, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4303), "USD", new DateTime(2021, 5, 28, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4303), 25, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #36145", "056 790 1441", null, 2150m, null, null, 2, -1 },
                    { -35, "Moq address #27803", new DateTime(2022, 6, 20, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4484), "USD", new DateTime(2022, 6, 24, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4484), 26, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #52405", "056 790 1441", null, 400m, null, null, 15, -1 },
                    { -34, "Moq address #92958", new DateTime(2022, 10, 10, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4477), "USD", new DateTime(2022, 10, 15, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4477), 16, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #69364", "056 790 1441", null, 2000m, null, null, 9, -1 },
                    { -33, "Moq address #38570", new DateTime(2022, 11, 16, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4470), "USD", new DateTime(2022, 11, 22, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4470), 0, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #96692", "056 790 1441", null, 4100m, null, null, 2, -1 },
                    { -32, "Moq address #10177", new DateTime(2021, 10, 5, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4464), "USD", new DateTime(2021, 10, 6, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4464), 10, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #72127", "056 790 1441", null, 800m, null, null, 3, -1 },
                    { -31, "Moq address #27327", new DateTime(2021, 3, 23, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4458), "USD", new DateTime(2021, 3, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4458), 18, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #96309", "056 790 1441", null, 1750m, null, null, 8, -1 },
                    { -30, "Moq address #25392", new DateTime(2020, 8, 7, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4452), "USD", new DateTime(2020, 8, 13, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4452), 27, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #18055", "056 790 1441", null, 2800m, null, null, 2, -1 },
                    { -3, "Moq address #17644", new DateTime(2021, 12, 2, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4178), "USD", new DateTime(2021, 12, 5, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4178), 7, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #70890", "056 790 1441", null, 1300m, null, null, 4, -1 },
                    { -28, "Moq address #12462", new DateTime(2021, 6, 2, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4439), "USD", new DateTime(2021, 6, 8, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4439), 11, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #55585", "056 790 1441", null, 1900m, null, null, 0, -1 },
                    { -27, "Moq address #85192", new DateTime(2021, 9, 3, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4434), "USD", new DateTime(2021, 9, 6, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4434), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #82680", "056 790 1441", null, 2750m, null, null, 15, -1 },
                    { -26, "Moq address #45447", new DateTime(2021, 2, 11, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4428), "USD", new DateTime(2021, 2, 17, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4428), 18, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #72592", "056 790 1441", null, 4300m, null, null, 2, -1 },
                    { -25, "Moq address #93654", new DateTime(2021, 11, 3, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4422), "USD", new DateTime(2021, 11, 9, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4422), 20, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #43693", "056 790 1441", null, 2550m, null, null, 0, -1 },
                    { -24, "Moq address #88040", new DateTime(2022, 8, 21, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4415), "USD", new DateTime(2022, 8, 22, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4415), 2, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #33979", "056 790 1441", null, 3900m, null, null, 5, -1 },
                    { -23, "Moq address #73037", new DateTime(2022, 8, 19, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4408), "USD", new DateTime(2022, 8, 25, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4408), 24, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #96144", "056 790 1441", null, 2100m, null, null, 12, -1 },
                    { -22, "Moq address #84702", new DateTime(2022, 7, 30, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4315), "USD", new DateTime(2022, 8, 5, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4315), 26, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #46608", "056 790 1441", null, 3300m, null, null, 14, -1 },
                    { -29, "Moq address #72707", new DateTime(2021, 8, 6, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4445), "USD", new DateTime(2021, 8, 8, 20, 59, 4, 251, DateTimeKind.Local).AddTicks(4445), 20, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #87863", "056 790 1441", null, 1350m, null, null, 9, -1 }
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 1, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8515), new DateTime(2013, 11, 24, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2014, 1, 2, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8509), new DateTime(2013, 12, 26, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 3, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8503), new DateTime(2016, 1, 27, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 3, 4, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8495), new DateTime(2016, 2, 26, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 5, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8489), new DateTime(2018, 3, 29, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 5, 6, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8474), new DateTime(2018, 4, 29, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 7, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8324), new DateTime(2020, 5, 31, 20, 59, 4, 240, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 7, 8, 20, 59, 4, 238, DateTimeKind.Local).AddTicks(4842), new DateTime(2020, 7, 1, 20, 59, 4, 238, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 16, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(95), new DateTime(2020, 10, 1, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 18, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(583), new DateTime(2020, 11, 3, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(601), new DateTime(2020, 12, 5, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 22, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(610), new DateTime(2022, 1, 7, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 24, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(619), new DateTime(2022, 2, 9, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(628), new DateTime(2022, 3, 11, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 28, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(637), new DateTime(2023, 4, 13, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 30, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(646), new DateTime(2023, 5, 15, 20, 59, 4, 241, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "jHGhAG8pBzaHPNR2unIpy6L4iro/UkmVUGehjewZ/RuXS/N/Cu4UbFZ7w31eDBc+");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "FqrFKIijWh7KvDluFoBoF0gQetT6Rgfm1tBY6soLJnIXW1+0pK3D4+UvPjzd2jdx");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "aKVpxX2Ru486GJr9yZq09tJyL5xA3yxNrUxwQD1NqGy/VhSgwOgfeI5v2DS5EC//");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "rduCaYw1Fggl3vi52n35bDebFYLLcn3PFETpWOyvsOwbDMO5Pj3cMXdfYyTN3o1+");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "POSKF49CuaGL2gMi4zM/HlWW9HGxwPZRKV3duaUTRihRKCfAWxEqWcf5w0rEWICW");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Link", "Name", "Note", "Price" },
                values: new object[] { "Sholom-Aleikhema Street, 4/26, Dnipro", new DateTime(2020, 7, 4, 12, 43, 59, 430, DateTimeKind.Local).AddTicks(9011), new DateTime(2020, 7, 9, 12, 43, 59, 430, DateTimeKind.Local).AddTicks(9049), 2, "http://menorah-center.com", "Menorah", "056 717 7000", 90m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Dmytra Yavornytskoho Avenue, 67К, Dnipro", new DateTime(2020, 6, 27, 12, 43, 59, 430, DateTimeKind.Local).AddTicks(1665), new DateTime(2020, 6, 29, 12, 43, 59, 430, DateTimeKind.Local).AddTicks(2445), 1, "Grand Hotel Ukraine", 100m, 1 });

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
