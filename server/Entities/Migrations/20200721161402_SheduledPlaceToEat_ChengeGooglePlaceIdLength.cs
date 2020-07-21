using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class SheduledPlaceToEat_ChengeGooglePlaceIdLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AlterColumn<string>(
                name: "GooglePlaceId",
                table: "scheduledPlaceToEat",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #57879", new DateTime(2023, 2, 27, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2988), 6, new DateTime(2023, 2, 28, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2988), 2, "Moq Hotel #15049", 1500m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #27842", new DateTime(2020, 8, 18, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2971), 7, new DateTime(2020, 8, 22, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2971), 3, "Moq Hotel #29682", 2300m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #53710", new DateTime(2021, 5, 24, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2954), 1, new DateTime(2021, 5, 28, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2954), 6, "Moq Hotel #89802", 4450m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #41014", new DateTime(2020, 8, 19, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2936), 5, new DateTime(2020, 8, 23, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2936), 5, "Moq Hotel #11211", 1250m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #17863", new DateTime(2022, 9, 13, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2920), 6, new DateTime(2022, 9, 14, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2920), 9, "Moq Hotel #82108", 800m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #57846", new DateTime(2020, 9, 16, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2904), 2, new DateTime(2020, 9, 21, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2904), 10, "Moq Hotel #39480", 3550m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #39830", new DateTime(2021, 12, 18, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2887), 1, new DateTime(2021, 12, 24, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2887), 10, "Moq Hotel #27819", 4150m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #81576", new DateTime(2022, 11, 16, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2863), 2, new DateTime(2022, 11, 18, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2863), 4, "Moq Hotel #69439", 3100m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #62474", new DateTime(2020, 8, 19, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2847), 4, new DateTime(2020, 8, 21, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2847), 6, "Moq Hotel #86341", 1200m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #22701", new DateTime(2022, 11, 23, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2830), 7, new DateTime(2022, 11, 24, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2830), 7, "Moq Hotel #92577", 2750m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #56220", new DateTime(2022, 5, 26, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2814), 5, new DateTime(2022, 5, 29, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2814), 1, "Moq Hotel #33075", 4600m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #19604", new DateTime(2022, 3, 3, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2798), new DateTime(2022, 3, 8, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2798), 10, "Moq Hotel #39545", 2300m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #68247", new DateTime(2022, 6, 27, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2781), new DateTime(2022, 7, 3, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2781), 5, "Moq Hotel #96774", 1100m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #64703", new DateTime(2021, 4, 18, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2765), 7, new DateTime(2021, 4, 24, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2765), 6, "Moq Hotel #96803", 2700m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #81245", new DateTime(2021, 11, 17, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2750), 5, new DateTime(2021, 11, 18, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2750), 2, "Moq Hotel #15413", 1900m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #93696", new DateTime(2021, 5, 24, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2733), 6, new DateTime(2021, 5, 29, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2733), 6, "Moq Hotel #60732", 3400m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #39067", new DateTime(2022, 2, 21, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2716), 2, new DateTime(2022, 2, 24, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2716), 2, "Moq Hotel #30628", 250m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #94104", new DateTime(2020, 11, 11, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2700), 1, new DateTime(2020, 11, 17, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2700), 6, "Moq Hotel #41175", 2500m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #97337", new DateTime(2023, 2, 28, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2684), 8, new DateTime(2023, 3, 3, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2684), 7, "Moq Hotel #67277", 200m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #53505", new DateTime(2022, 12, 26, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2668), 3, new DateTime(2023, 1, 1, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2668), 9, "Moq Hotel #27602", 1850m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #98631", new DateTime(2021, 1, 4, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2652), 1, new DateTime(2021, 1, 10, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2652), 10, "Moq Hotel #36867", 1900m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #10493", new DateTime(2022, 3, 12, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2636), 1, new DateTime(2022, 3, 15, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2636), 5, "Moq Hotel #86208", 4900m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #60967", new DateTime(2022, 5, 11, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2619), 5, new DateTime(2022, 5, 16, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2619), 2, "Moq Hotel #70825", 4600m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #66741", new DateTime(2022, 4, 3, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2603), 1, new DateTime(2022, 4, 5, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2603), 7, "Moq Hotel #59362", 2750m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #58121", new DateTime(2022, 1, 19, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2587), 8, new DateTime(2022, 1, 25, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2587), 8, "Moq Hotel #12127", 350m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #20678", new DateTime(2021, 8, 15, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2571), 2, new DateTime(2021, 8, 19, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2571), 7, "Moq Hotel #54683", 950m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #65632", new DateTime(2020, 9, 28, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2554), new DateTime(2020, 9, 29, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2554), 1, "Moq Hotel #95674", 2750m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #55734", new DateTime(2021, 8, 19, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2538), 2, new DateTime(2021, 8, 22, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2538), 1, "Moq Hotel #40904", 300m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #78897", new DateTime(2022, 6, 22, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2521), 5, new DateTime(2022, 6, 28, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2521), 6, "Moq Hotel #22961", 3550m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #76639", new DateTime(2022, 11, 21, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2505), 8, new DateTime(2022, 11, 26, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2505), 6, "Moq Hotel #74597", 850m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #69907", new DateTime(2023, 4, 2, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2488), 5, new DateTime(2023, 4, 3, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2488), 10, "Moq Hotel #39004", 2900m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #63631", new DateTime(2021, 8, 23, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2462), new DateTime(2021, 8, 29, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2462), 7, "Moq Hotel #73828", 3600m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #54249", new DateTime(2020, 9, 26, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2445), 6, new DateTime(2020, 9, 27, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2445), 9, "Moq Hotel #96772", 450m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #18974", new DateTime(2022, 8, 29, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2429), 5, new DateTime(2022, 9, 2, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2429), 10, "Moq Hotel #80385", 4100m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #86481", new DateTime(2020, 10, 25, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2411), 6, new DateTime(2020, 10, 26, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2411), 3, "Moq Hotel #53046", 2250m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #90630", new DateTime(2020, 12, 15, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2392), 5, new DateTime(2020, 12, 19, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2392), 8, "Moq Hotel #56466", 2800m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #63791", new DateTime(2022, 1, 5, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2376), 1, new DateTime(2022, 1, 8, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2376), "Moq Hotel #36876", 1700m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #33191", new DateTime(2020, 11, 19, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2360), 7, new DateTime(2020, 11, 25, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2360), 2, "Moq Hotel #58986", 4650m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #20234", new DateTime(2022, 7, 26, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2343), 4, new DateTime(2022, 7, 31, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2343), 2, "Moq Hotel #76137", 2600m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #62233", new DateTime(2022, 1, 10, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2327), 5, new DateTime(2022, 1, 15, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2327), 8, "Moq Hotel #98928", 400m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #67106", new DateTime(2020, 10, 15, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2310), 8, new DateTime(2020, 10, 17, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2310), 7, "Moq Hotel #35095", 2300m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #79829", new DateTime(2022, 11, 1, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2294), 5, new DateTime(2022, 11, 2, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2294), 6, "Moq Hotel #24922", 500m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #28062", new DateTime(2023, 1, 14, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2277), 3, new DateTime(2023, 1, 17, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2277), 9, "Moq Hotel #63854", 700m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #58447", new DateTime(2022, 10, 25, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2261), new DateTime(2022, 10, 31, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2261), 9, "Moq Hotel #66113", 3400m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #72458", new DateTime(2023, 2, 11, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2244), 5, new DateTime(2023, 2, 17, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2244), 5, "Moq Hotel #32350", 4000m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #74868", new DateTime(2021, 7, 20, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2228), 4, new DateTime(2021, 7, 25, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2228), 8, "Moq Hotel #46416", 2750m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #62575", new DateTime(2021, 2, 1, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2211), 8, new DateTime(2021, 2, 4, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2211), 3, "Moq Hotel #39476", 4200m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #24834", new DateTime(2020, 12, 19, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2195), 8, new DateTime(2020, 12, 24, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2195), 9, "Moq Hotel #66331", 2500m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #50402", new DateTime(2023, 4, 13, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2179), 7, new DateTime(2023, 4, 14, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2179), "Moq Hotel #69701", 3800m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #70143", new DateTime(2021, 12, 26, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2162), 3, new DateTime(2021, 12, 29, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2162), 6, "Moq Hotel #46268", 400m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #10328", new DateTime(2022, 10, 13, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2144), 5, new DateTime(2022, 10, 16, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2144), "Moq Hotel #61991", 4600m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #90043", new DateTime(2022, 9, 7, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2124), 8, new DateTime(2022, 9, 11, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2124), 4, "Moq Hotel #10702", 3450m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #31507", new DateTime(2021, 12, 5, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2107), 1, new DateTime(2021, 12, 11, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2107), 2, "Moq Hotel #35013", 1300m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #38039", new DateTime(2021, 9, 14, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2055), 8, new DateTime(2021, 9, 16, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2055), 2, "Moq Hotel #88508", 3300m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #50529", new DateTime(2023, 4, 10, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2039), 7, new DateTime(2023, 4, 15, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2039), 2, "Moq Hotel #46340", 2150m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #65394", new DateTime(2023, 3, 15, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2022), 8, new DateTime(2023, 3, 19, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2022), 8, "Moq Hotel #68212", 2750m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #90469", new DateTime(2020, 8, 14, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2006), 2, new DateTime(2020, 8, 16, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(2006), 6, "Moq Hotel #95263", 3500m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #47886", new DateTime(2020, 11, 12, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1989), 1, new DateTime(2020, 11, 15, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1989), 5, "Moq Hotel #41958", 50m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #59565", new DateTime(2023, 1, 7, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1972), 4, new DateTime(2023, 1, 9, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1972), 6, "Moq Hotel #52373", 800m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #97995", new DateTime(2022, 11, 26, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1946), 7, new DateTime(2022, 11, 29, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1946), 2, "Moq Hotel #55006", 450m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #46879", new DateTime(2022, 12, 8, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1886), 1, new DateTime(2022, 12, 10, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1886), 7, "Moq Hotel #61488", 300m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #63817", new DateTime(2021, 4, 6, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1869), 8, new DateTime(2021, 4, 8, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1869), 10, "Moq Hotel #16838", 100m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #56466", new DateTime(2022, 11, 18, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1851), 6, new DateTime(2022, 11, 23, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1851), 2, "Moq Hotel #11772", 600m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "Name", "Price" },
                values: new object[] { "Moq address #21333", new DateTime(2021, 12, 9, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1825), new DateTime(2021, 12, 15, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1825), "Moq Hotel #13338", 1200m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #73850", new DateTime(2021, 12, 6, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1807), 8, new DateTime(2021, 12, 7, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1807), 5, "Moq Hotel #30382", 2350m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #18236", new DateTime(2022, 4, 1, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1771), 3, new DateTime(2022, 4, 6, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1771), 6, "Moq Hotel #22356", 2700m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #88407", new DateTime(2022, 5, 20, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1472), new DateTime(2022, 5, 23, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(1472), 1, "Moq Hotel #38613", 2550m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #80307", new DateTime(2021, 2, 13, 19, 14, 0, 333, DateTimeKind.Local).AddTicks(8585), 5, new DateTime(2021, 2, 19, 19, 14, 0, 333, DateTimeKind.Local).AddTicks(8585), 7, "Moq Hotel #46156", 1650m, 3 });

            migrationBuilder.InsertData(
                table: "accommodations",
                columns: new[] { "Id", "Address", "ArrivalDateTime", "CountryId", "Currency", "DepartureDateTime", "GuestCount", "Link", "Name", "Note", "Photos", "Price", "Rating", "RatingTotal", "RoomsCount", "UserId" },
                values: new object[,]
                {
                    { -72, "Moq address #19070", new DateTime(2020, 10, 16, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(3021), 5, "USD", new DateTime(2020, 10, 18, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(3021), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #28524", "056 790 1441", null, 3250m, null, null, 1, -1 },
                    { -71, "Moq address #97433", new DateTime(2020, 9, 9, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(3005), 8, "USD", new DateTime(2020, 9, 11, 19, 14, 0, 335, DateTimeKind.Local).AddTicks(3005), 4, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #35829", "056 790 1441", null, 2600m, null, null, 2, -1 }
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 21, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6635), new DateTime(2013, 12, 14, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2014, 1, 22, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6620), new DateTime(2014, 1, 15, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 23, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6601), new DateTime(2016, 2, 16, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 3, 24, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6576), new DateTime(2016, 3, 17, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 25, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6557), new DateTime(2018, 4, 18, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 5, 26, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6521), new DateTime(2018, 5, 19, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 27, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6138), new DateTime(2020, 6, 20, 19, 14, 0, 302, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 7, 28, 19, 14, 0, 296, DateTimeKind.Local).AddTicks(6507), new DateTime(2020, 7, 21, 19, 14, 0, 296, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 5, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(928), new DateTime(2020, 10, 21, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 8, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2057), new DateTime(2020, 11, 23, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 1, 9, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2111), new DateTime(2020, 12, 25, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 11, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2135), new DateTime(2022, 1, 27, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 16, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2159), new DateTime(2022, 3, 1, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2181), new DateTime(2022, 3, 31, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 18, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2204), new DateTime(2023, 5, 3, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 19, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2225), new DateTime(2023, 6, 4, 19, 14, 0, 303, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "7PHEn1/qus3e6DCZSj47oLY3yjwh0/gxvMLPnFwhoO94/Y/bYxBg3mtVly6BYKK7");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "HtTJJHAn8TRKW4CvECtpkKG/dLnKKrwd6mCDpa0M3s4HOyHrEy60b1YJsMMaQkh3");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "+bREWkxPBr84jstsKWljlshh805K2zKTBB9xVQ0D4+yJcJVc0f/LH+lg4k2njx/q");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "h9jSOdpFE7wJf6BKAq5dTQf1vy45ljoCKo0JULxYm7rZ1NAL32G8f6kD4Cieu55G");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "wbwar+fd6B4nCSO9hC4ICXCCRynyED7H0VchuS2R7Rsf2GEXpWGaHQf3DvB8UV53");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.AlterColumn<string>(
                name: "GooglePlaceId",
                table: "scheduledPlaceToEat",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #84296", new DateTime(2022, 10, 25, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6555), 2, new DateTime(2022, 10, 26, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6555), 5, "Moq Hotel #94002", 850m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #25467", new DateTime(2020, 7, 21, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6548), 1, new DateTime(2020, 7, 26, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6548), 2, "Moq Hotel #18931", 700m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #56429", new DateTime(2021, 11, 2, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6542), 8, new DateTime(2021, 11, 3, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6542), 7, "Moq Hotel #24801", 1700m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #25885", new DateTime(2021, 4, 21, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6510), 2, new DateTime(2021, 4, 26, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6510), 10, "Moq Hotel #59410", 3650m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #28626", new DateTime(2022, 10, 31, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6503), 1, new DateTime(2022, 11, 5, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6503), 4, "Moq Hotel #28129", 4950m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #89134", new DateTime(2022, 1, 9, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6496), 3, new DateTime(2022, 1, 13, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6496), 7, "Moq Hotel #53601", 950m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #72130", new DateTime(2021, 8, 5, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6490), 6, new DateTime(2021, 8, 9, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6490), 8, "Moq Hotel #71523", 2300m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #98665", new DateTime(2022, 7, 10, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6483), 4, new DateTime(2022, 7, 12, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6483), 1, "Moq Hotel #12519", 1150m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #29521", new DateTime(2021, 8, 24, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6477), 7, new DateTime(2021, 8, 29, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6477), 7, "Moq Hotel #52113", 4850m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #58070", new DateTime(2021, 5, 21, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6471), 1, new DateTime(2021, 5, 25, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6471), 2, "Moq Hotel #73552", 3700m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #52017", new DateTime(2022, 6, 16, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6464), 7, new DateTime(2022, 6, 18, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6464), 3, "Moq Hotel #32874", 3550m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #20904", new DateTime(2021, 12, 13, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6458), new DateTime(2021, 12, 15, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6458), 7, "Moq Hotel #61894", 2000m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #83894", new DateTime(2023, 1, 17, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6452), new DateTime(2023, 1, 19, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6452), 6, "Moq Hotel #33006", 1300m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #29891", new DateTime(2022, 1, 3, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6446), 6, new DateTime(2022, 1, 5, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6446), 10, "Moq Hotel #80500", 4550m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #82285", new DateTime(2023, 3, 28, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6440), 8, new DateTime(2023, 3, 31, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6440), 6, "Moq Hotel #98673", 1500m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #73407", new DateTime(2020, 12, 8, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6434), 5, new DateTime(2020, 12, 9, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6434), 5, "Moq Hotel #38748", 2400m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #25172", new DateTime(2020, 9, 24, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6428), 6, new DateTime(2020, 9, 28, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6428), 4, "Moq Hotel #64971", 2000m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #36454", new DateTime(2021, 12, 26, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6422), 3, new DateTime(2021, 12, 31, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6422), 5, "Moq Hotel #26230", 250m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #49996", new DateTime(2023, 1, 4, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6416), 7, new DateTime(2023, 1, 6, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6416), 5, "Moq Hotel #92642", 3950m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #38137", new DateTime(2021, 4, 19, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6409), 5, new DateTime(2021, 4, 23, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6409), 5, "Moq Hotel #97211", 2100m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #87367", new DateTime(2022, 6, 13, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6403), 3, new DateTime(2022, 6, 17, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6403), 5, "Moq Hotel #39595", 1800m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #39421", new DateTime(2022, 7, 23, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6397), 6, new DateTime(2022, 7, 27, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6397), 8, "Moq Hotel #46500", 3850m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #47218", new DateTime(2021, 9, 11, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6391), 8, new DateTime(2021, 9, 16, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6391), 7, "Moq Hotel #55184", 1050m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #37995", new DateTime(2020, 10, 1, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6384), 7, new DateTime(2020, 10, 4, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6384), 5, "Moq Hotel #85599", 1950m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #59875", new DateTime(2022, 11, 15, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6319), 7, new DateTime(2022, 11, 16, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6319), 7, "Moq Hotel #76797", 4750m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #71297", new DateTime(2021, 12, 27, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6312), 4, new DateTime(2022, 1, 1, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6312), 10, "Moq Hotel #36545", 1100m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #64471", new DateTime(2021, 7, 13, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6307), new DateTime(2021, 7, 18, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6307), 2, "Moq Hotel #30674", 2550m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #55819", new DateTime(2022, 11, 11, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6300), 1, new DateTime(2022, 11, 16, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6300), 7, "Moq Hotel #93200", 1550m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #18250", new DateTime(2022, 5, 22, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6294), 6, new DateTime(2022, 5, 24, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6294), 7, "Moq Hotel #32308", 2500m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #14336", new DateTime(2021, 4, 19, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6288), 3, new DateTime(2021, 4, 23, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6288), 7, "Moq Hotel #76240", 3050m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #28415", new DateTime(2021, 1, 30, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6282), 8, new DateTime(2021, 2, 3, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6282), 3, "Moq Hotel #61931", 2400m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #79036", new DateTime(2022, 11, 23, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6276), new DateTime(2022, 11, 24, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6276), 9, "Moq Hotel #51580", 500m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #99837", new DateTime(2021, 1, 21, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6270), 7, new DateTime(2021, 1, 23, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6270), 5, "Moq Hotel #10979", 850m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #94546", new DateTime(2020, 9, 14, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6264), 6, new DateTime(2020, 9, 19, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6264), 2, "Moq Hotel #52086", 4950m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #69156", new DateTime(2021, 2, 7, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6257), 1, new DateTime(2021, 2, 12, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6257), 10, "Moq Hotel #12331", 1300m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #55850", new DateTime(2020, 9, 13, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6251), 8, new DateTime(2020, 9, 19, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6251), 2, "Moq Hotel #70020", 2200m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #65669", new DateTime(2022, 5, 28, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6245), 7, new DateTime(2022, 6, 3, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6245), "Moq Hotel #58165", 1750m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #78707", new DateTime(2021, 10, 23, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6238), 4, new DateTime(2021, 10, 26, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6238), 3, "Moq Hotel #67491", 4750m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #24932", new DateTime(2021, 5, 10, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6231), 2, new DateTime(2021, 5, 12, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6231), 5, "Moq Hotel #29581", 2650m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #97241", new DateTime(2022, 8, 7, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6225), 6, new DateTime(2022, 8, 10, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6225), 6, "Moq Hotel #22420", 600m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #34250", new DateTime(2022, 12, 21, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6219), 2, new DateTime(2022, 12, 26, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6219), 6, "Moq Hotel #62995", 2350m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #18195", new DateTime(2021, 1, 1, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6213), 6, new DateTime(2021, 1, 6, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6213), 9, "Moq Hotel #39684", 4350m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #77122", new DateTime(2021, 10, 7, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6207), 8, new DateTime(2021, 10, 13, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6207), 7, "Moq Hotel #57879", 4400m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #76802", new DateTime(2022, 5, 2, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6201), new DateTime(2022, 5, 4, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6201), 3, "Moq Hotel #60273", 3600m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #69754", new DateTime(2022, 8, 8, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6194), 7, new DateTime(2022, 8, 12, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6194), 1, "Moq Hotel #40824", 600m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #73034", new DateTime(2022, 11, 24, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6188), 2, new DateTime(2022, 11, 25, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6188), 7, "Moq Hotel #11385", 2700m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #20735", new DateTime(2020, 12, 13, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6181), 3, new DateTime(2020, 12, 19, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6181), 6, "Moq Hotel #88624", 50m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #48779", new DateTime(2020, 7, 13, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6142), 5, new DateTime(2020, 7, 18, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6142), 7, "Moq Hotel #48740", 1700m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #62231", new DateTime(2022, 7, 1, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6136), 5, new DateTime(2022, 7, 5, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6136), "Moq Hotel #26135", 4600m, 1 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #13299", new DateTime(2020, 10, 31, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6130), 4, new DateTime(2020, 11, 1, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6130), 7, "Moq Hotel #81140", 3400m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #30100", new DateTime(2022, 10, 23, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6124), 3, new DateTime(2022, 10, 24, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6124), "Moq Hotel #62143", 3100m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #39772", new DateTime(2022, 8, 21, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6118), 2, new DateTime(2022, 8, 26, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6118), 9, "Moq Hotel #49597", 2650m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #33116", new DateTime(2021, 4, 29, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6112), 2, new DateTime(2021, 5, 2, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6112), 5, "Moq Hotel #53755", 1800m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #81400", new DateTime(2021, 5, 16, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6104), 2, new DateTime(2021, 5, 17, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6104), 7, "Moq Hotel #70900", 4900m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #58086", new DateTime(2021, 7, 3, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6098), 2, new DateTime(2021, 7, 7, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6098), 9, "Moq Hotel #41827", 2600m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #95355", new DateTime(2020, 9, 3, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6092), 4, new DateTime(2020, 9, 6, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6092), 1, "Moq Hotel #73165", 1400m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #46271", new DateTime(2022, 5, 16, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6085), 4, new DateTime(2022, 5, 22, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6085), 8, "Moq Hotel #66581", 2000m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #53617", new DateTime(2022, 5, 4, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6079), 4, new DateTime(2022, 5, 10, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6079), 6, "Moq Hotel #20217", 2550m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #81594", new DateTime(2022, 11, 20, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6073), 5, new DateTime(2022, 11, 25, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6073), 1, "Moq Hotel #25412", 3500m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #11406", new DateTime(2023, 1, 26, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6066), 1, new DateTime(2023, 2, 1, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6066), 9, "Moq Hotel #81499", 1000m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #78254", new DateTime(2021, 7, 23, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6061), 5, new DateTime(2021, 7, 25, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6061), 10, "Moq Hotel #10632", 700m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #50424", new DateTime(2022, 11, 22, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6054), 5, new DateTime(2022, 11, 25, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6054), 8, "Moq Hotel #59735", 750m, 3 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #36101", new DateTime(2020, 9, 12, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6047), 2, new DateTime(2020, 9, 14, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6047), 8, "Moq Hotel #27297", 2350m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "Name", "Price" },
                values: new object[] { "Moq address #41296", new DateTime(2021, 1, 2, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6041), new DateTime(2021, 1, 4, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6041), "Moq Hotel #84385", 2400m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #86934", new DateTime(2022, 3, 28, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6034), 2, new DateTime(2022, 3, 30, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6034), 1, "Moq Hotel #21295", 1050m, 4 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #89230", new DateTime(2020, 8, 23, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6026), 4, new DateTime(2020, 8, 26, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6026), 10, "Moq Hotel #40338", 2450m, 2 });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Address", "ArrivalDateTime", "DepartureDateTime", "GuestCount", "Name", "Price" },
                values: new object[] { "Moq address #23368", new DateTime(2022, 1, 11, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6020), new DateTime(2022, 1, 12, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6020), 9, "Moq Hotel #22474", 4050m });

            migrationBuilder.UpdateData(
                table: "accommodations",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Address", "ArrivalDateTime", "CountryId", "DepartureDateTime", "GuestCount", "Name", "Price", "RoomsCount" },
                values: new object[] { "Moq address #90293", new DateTime(2022, 10, 24, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6011), 2, new DateTime(2022, 10, 27, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(6011), 9, "Moq Hotel #88159", 2750m, 1 });

            migrationBuilder.InsertData(
                table: "accommodations",
                columns: new[] { "Id", "Address", "ArrivalDateTime", "CountryId", "Currency", "DepartureDateTime", "GuestCount", "Link", "Name", "Note", "Photos", "Price", "Rating", "RatingTotal", "RoomsCount", "UserId" },
                values: new object[,]
                {
                    { -2, "Moq address #51581", new DateTime(2021, 2, 20, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(5946), 2, "USD", new DateTime(2021, 2, 21, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(5946), 8, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #70790", "056 790 1441", null, 2850m, null, null, 1, -1 },
                    { -1, "Moq address #82751", new DateTime(2021, 11, 7, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(2239), 3, "USD", new DateTime(2021, 11, 10, 16, 11, 2, 525, DateTimeKind.Local).AddTicks(2239), 5, "http://www.grand-hotel-ukraine.dp.ua", "Moq Hotel #64328", "056 790 1441", null, 950m, null, null, 3, -1 }
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 7, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2631), new DateTime(2013, 11, 30, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2014, 1, 8, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2625), new DateTime(2014, 1, 1, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 9, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2619), new DateTime(2016, 2, 2, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 3, 10, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2610), new DateTime(2016, 3, 3, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 11, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2571), new DateTime(2018, 4, 4, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 5, 12, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2560), new DateTime(2018, 5, 5, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 13, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2489), new DateTime(2020, 6, 6, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 7, 14, 16, 11, 2, 514, DateTimeKind.Local).AddTicks(375), new DateTime(2020, 7, 7, 16, 11, 2, 514, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 10, 22, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(3959), new DateTime(2020, 10, 7, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 11, 24, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4342), new DateTime(2020, 11, 9, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 26, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4353), new DateTime(2020, 12, 11, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 28, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4362), new DateTime(2022, 1, 13, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 2, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4371), new DateTime(2022, 2, 15, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 1, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4380), new DateTime(2022, 3, 17, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 4, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4389), new DateTime(2023, 4, 19, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 5, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4398), new DateTime(2023, 5, 21, 16, 11, 2, 516, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "ZXNmZiksKKbQWXfqkfeuY2Gupxag/q/QL0Z0TPyKL83kcMXmT37OI+x5eKR7Qtix");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "581KOJYb6xx4hrqEL+UrSTFfZLJkyeCYERr1DOjgxpFI3tNgADUkvtPD7sCn3cpC");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "y00QukffVwA1nYLD195YiKWYyBu80PoOHQF1X9Pw0JBZVG/Ni0dZUkWgfrEW/Hc4");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "kdxc4e4VGcwxoYYmFoiydbdMmopdAg2KjocK2XJPNY/4NzTG0PwDSrMjUjjZbY9R");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "Jk0dkbYCmXnXPtqOcX3hB/n3F/h1uGFjUx/8Ud3iVkkeZxd9etG4XS09L4VZZqmX");
        }
    }
}
