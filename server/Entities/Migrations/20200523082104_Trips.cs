using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Trips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 10, 23, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(721), new DateTime(2013, 10, 16, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 24, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(707), new DateTime(2013, 11, 17, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2015, 12, 25, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(691), new DateTime(2015, 12, 18, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 26, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(670), new DateTime(2016, 1, 19, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 2, 27, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(655), new DateTime(2018, 2, 20, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 28, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(623), new DateTime(2018, 3, 21, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 4, 29, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(315), new DateTime(2020, 4, 22, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 30, 11, 21, 3, 453, DateTimeKind.Local).AddTicks(5132), new DateTime(2020, 5, 23, 11, 21, 3, 453, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "a8APt+FH76oSxud6xByXF80/9EEw3Md/rZ/Rh9/plZtnRd75zKHPUh1Y0Fmc+Xrg");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "h1sk1rNrmMXAf0vXAGf+fU8YPLqop2kOQaRTQ4HWx1+w034u6Gt16nfgWNNArV5f");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "9kQ0AnWvFManewW+MD4WpDnYhbhQ3PmWCGBiAbzgSoJLqK0EbGstl5YpWNGO5Pus");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "7JX8jQHqx1hd4HUMnBKbYO7ihBeVMl8jngm6qVXomOJx2xAlm1IuzXS5nLyGtIe1");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "r5AcRG+U3Yi5olP/rcToFJwKu2KH4PB6NJ99/fPCE8cp6SnyHWbir79TnanNAeVI");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 10, 23, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1207), new DateTime(2013, 10, 16, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 24, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1192), new DateTime(2013, 11, 17, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2015, 12, 25, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1177), new DateTime(2015, 12, 18, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 26, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1154), new DateTime(2016, 1, 19, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 2, 27, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1137), new DateTime(2018, 2, 20, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 28, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1104), new DateTime(2018, 3, 21, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 4, 29, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(805), new DateTime(2020, 4, 22, 11, 20, 51, 716, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 30, 11, 20, 51, 711, DateTimeKind.Local).AddTicks(2776), new DateTime(2020, 5, 23, 11, 20, 51, 711, DateTimeKind.Local).AddTicks(2776) });

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
        }
    }
}
