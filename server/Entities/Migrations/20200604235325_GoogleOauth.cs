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
                values: new object[] { new DateTime(2013, 11, 5, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7227), new DateTime(2013, 10, 29, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 6, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7221), new DateTime(2013, 11, 29, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 7, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7214), new DateTime(2015, 12, 31, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 8, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7206), new DateTime(2016, 2, 1, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 9, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7199), new DateTime(2018, 3, 2, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 10, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7186), new DateTime(2018, 4, 3, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 11, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7046), new DateTime(2020, 5, 4, 2, 53, 25, 33, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 12, 2, 53, 25, 31, DateTimeKind.Local).AddTicks(5250), new DateTime(2020, 6, 5, 2, 53, 25, 31, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "UWgSQNtAfogybuM/37qy+e5TKbQwwj7bSZrba8Nw+5sexrTrvprOD6Wjas5rdSfA");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "BhcXGg4a2kL1vRwRfjNV417FNyFKugLwfvYCh3n+Va94AlQnUkeGnoViJJb+0L9O");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "I2ZZ+2yloWpmOa5NYzbM8VEXkQBXme6GIBYLQrJdWv/C3C9LQw6lIjAIOu92usqJ");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "EtwTgsWilouR140gsX9HP3XpQb2JeMeRttBw9vLt1uUQHNA8N2T7bmRKQ+MmZli9");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "GihIs8O98aZFO2co1kVF5GX6YIekHXSW+UWW5q+LqHsQcQk4Q1K9JMtUEiJZyzan");
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
