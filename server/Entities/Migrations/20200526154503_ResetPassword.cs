using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class ResetPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResetPasswordToken",
                table: "users",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResetPasswordToken",
                table: "users");

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 10, 25, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(700), new DateTime(2013, 10, 18, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 26, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(693), new DateTime(2013, 11, 19, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2015, 12, 27, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(686), new DateTime(2015, 12, 20, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 28, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(677), new DateTime(2016, 1, 21, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 1, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(670), new DateTime(2018, 2, 22, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 30, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(658), new DateTime(2018, 3, 23, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 1, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(509), new DateTime(2020, 4, 24, 2, 35, 35, 301, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 1, 2, 35, 35, 298, DateTimeKind.Local).AddTicks(8491), new DateTime(2020, 5, 25, 2, 35, 35, 298, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "qqUO4C0l9uuRrFuZemahbGlYAleg5c/uZsH1/i3ce2mkKLRZ414/fUX91OIJB5fH");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "IC4+slE3NE+hY4dXpzySnPpbbM39rqdVOnkkk1qVu1cgNqfYPPP5w5rvOgnK3br9");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "T1H29Rht3ksZtIAgU6W9x+Ibeb+bcay4TJxkzOeYW2zY68ZYiFKY++RGf2CtUEI8");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "XQDy8chHqNJQuE0llLEQ4ArXEfvOFkBlbK6apb9g3CsmrlhFmNRjMbUEl831OXmu");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "H5pVqpkivaTDpPJL3hEznscqDJ13j4vF1ri5UFxIXfUG9ZzmxCim3uNdh9lgpm2B");
        }
    }
}
