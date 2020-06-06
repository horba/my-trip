using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class GoogleOauth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleId",
                table: "users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 6, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8991), new DateTime(2013, 10, 30, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 7, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8985), new DateTime(2013, 11, 30, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 8, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8978), new DateTime(2016, 1, 1, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 9, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8969), new DateTime(2016, 2, 2, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 10, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8963), new DateTime(2018, 3, 3, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 11, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8950), new DateTime(2018, 4, 4, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 12, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8787), new DateTime(2020, 5, 5, 18, 18, 28, 168, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 13, 18, 18, 28, 166, DateTimeKind.Local).AddTicks(6942), new DateTime(2020, 6, 6, 18, 18, 28, 166, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "OOud1W38lNkIiGzsYCIM9BYN41hOP53A23hzimR2LSH0Xi77X5RK5LXMgt+HuNkS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "RagBObu5+kUspZ9UqF5ShZIvtO2i8SanxphDotAlDvtB1W7s721AheDLDApoj1ae");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "bgkkjrtmyIzonlZIPGTXTpxS/glBB0o4RC90zxK3+569ABEiMr0cmg9xGwBm1cyw");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "R6MHxLnIoK9EES3Mlsg8FNigTuLsV2E0x7M2I48Y3UCRJNNF++AumhJc6kae3R6z");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "g9DBKodifkvPmxLcIcK5bjqvnE5UbKrta+1ce5sz5feeW7H/VO8Ha5l+49h3IbWM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleId",
                table: "users");

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 10, 26, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5901), new DateTime(2013, 10, 19, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 27, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5866), new DateTime(2013, 11, 20, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2015, 12, 28, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5829), new DateTime(2015, 12, 21, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 29, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5748), new DateTime(2016, 1, 22, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 2, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5704), new DateTime(2018, 2, 23, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 31, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5630), new DateTime(2018, 3, 24, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 2, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(4835), new DateTime(2020, 4, 25, 18, 45, 1, 812, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 2, 18, 45, 1, 803, DateTimeKind.Local).AddTicks(5457), new DateTime(2020, 5, 26, 18, 45, 1, 803, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "g7ve2BVco912IY2N7Mlhf408MN8yaY04m3jtMxOxC+qGQ0HmCGEicCnIGtR1RR6W");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "4r2l8DLrfUTt9pK23FJJsPmElrR5d3I9ptd5hM0gM1VYIRwUoIyeahdrvsFkJIil");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "uoKMdEODXaUY2yHctblycr2D6PV6ion1ueb42IYExcJMRhyWRjTr3gnLdYEhVfqe");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "M/bMCgyu27dDfln1oN0wZStDgGQosGdqvlDDbNlqsrZWPZvQNQUbMQIywa/YRekl");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "0eZiIpNml4g31zT9IDR5k/iFoGlfdHD+pa11pQbLScWAggsdtyUBs4evZT+iT0eL");
        }
    }
}
