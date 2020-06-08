using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Tickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Adults = table.Column<int>(nullable: false),
                    Children = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketRoutes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(nullable: false),
                    DepartureDateTime = table.Column<DateTime>(nullable: false),
                    ArrivalDateTime = table.Column<DateTime>(nullable: false),
                    DepartureCode = table.Column<string>(nullable: true),
                    ArrivalCode = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketRoutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketRoutes_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Adults", "Children", "UserId" },
                values: new object[,]
                {
                    { -1, 5, 0, -1 },
                    { -2, 4, 0, -1 },
                    { -3, 3, 0, -1 },
                    { -4, 2, 0, -1 },
                    { -5, 1, 0, -1 }
                });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 10, 30, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6200), new DateTime(2013, 10, 23, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 12, 1, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6193), new DateTime(2013, 11, 24, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 1, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6185), new DateTime(2015, 12, 25, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 2, 2, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6174), new DateTime(2016, 1, 26, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 4, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6166), new DateTime(2018, 2, 25, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 4, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6150), new DateTime(2018, 3, 28, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 6, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(5911), new DateTime(2020, 4, 29, 15, 55, 41, 343, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 6, 15, 55, 41, 340, DateTimeKind.Local).AddTicks(7440), new DateTime(2020, 5, 30, 15, 55, 41, 340, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "lA9s6WVDhX/9ik4F2QpYhZqUAKXGnt69jNR0CG8lCFW27F8n+vYQSDSOt5hTnPYU");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "OhXVAOBpY7EV/2c2zvtR321sg4FVS2bw/bK0wT82OYbVkBbfUyXmCwfL0lAEuwA6");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "6JMOHkuhJv+h4+/5mEGl8DxMmR0Iyh2UlAI2vPEv6T1MAPFEiUxzDC1DOZVIayoL");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "bGGf3HcSSUiG70+akiTPlKZRdfrWshHktJSKF1IcYLsKwUmrYrD4TZC/STmWHt2G");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "Y976u2T+6V1ThKGpFgawAH4FHEyqJUVuwLRWPWUWp8C8h5+SYbuXFqbAAnivnQ6S");

            migrationBuilder.InsertData(
                table: "TicketRoutes",
                columns: new[] { "Id", "ArrivalCode", "ArrivalDateTime", "DepartureCode", "DepartureDateTime", "Price", "TicketId" },
                values: new object[,]
                {
                    { -1, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 1000, -1 },
                    { -2, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 900, -1 },
                    { -3, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 800, -2 },
                    { -4, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 700, -2 },
                    { -5, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 600, -3 },
                    { -6, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 500, -3 },
                    { -7, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 400, -4 },
                    { -8, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 300, -4 },
                    { -9, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 200, -5 },
                    { -10, "KBP", new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local), "KBK", new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local), 100, -5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketRoutes_TicketId",
                table: "TicketRoutes",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketRoutes");

            migrationBuilder.DropTable(
                name: "Tickets");

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
