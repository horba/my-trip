using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddUserOauthField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOauth",
                table: "users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 10, 29, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9376), new DateTime(2013, 10, 22, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 30, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9369), new DateTime(2013, 11, 23, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2015, 12, 31, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9363), new DateTime(2015, 12, 24, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 1, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9353), new DateTime(2016, 1, 25, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 4, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9346), new DateTime(2018, 2, 25, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 3, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9333), new DateTime(2018, 3, 27, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 5, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9175), new DateTime(2020, 4, 28, 22, 21, 54, 314, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 5, 22, 21, 54, 312, DateTimeKind.Local).AddTicks(6941), new DateTime(2020, 5, 29, 22, 21, 54, 312, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "Tn8kOZQvYGroCzka2lLIdVJ4eQPjdFt+YHdW/J4iaqokp0vcd3MOv05c4YBiwmBm");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "SEyC6fnHQEb3DFsSbvh6VjwwWL2GxjBClRJM67BavUKsBPsUbXjgJF/NnSgapr1m");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "+VneloBGDNt2mKUpfuh4knRJmdU1KIt0p3uQOrBrMrjQQ3LVBl/goG81JUz/KFvq");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "9AwI2qR3KDyLvu1XdoQt00qI87nL3yOKpoJZcFaKB1DXBvIzchAUfcz+EctzzTzp");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "+4iQPk7yJhk7+oHfxD3KGDeY4D66BYeIvbeIePU2gQ5Vyt1HxtyACMx/508WUmTJ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOauth",
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
