using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class UserAvatar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarFileName",
                table: "users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 10, 28, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(687), new DateTime(2013, 10, 21, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2013, 11, 29, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(671), new DateTime(2013, 11, 22, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2015, 12, 30, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(649), new DateTime(2015, 12, 23, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2016, 1, 31, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(531), new DateTime(2016, 1, 24, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 3, 4, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(513), new DateTime(2018, 2, 25, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2018, 4, 2, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(481), new DateTime(2018, 3, 26, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 5, 4, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(108), new DateTime(2020, 4, 27, 17, 13, 58, 283, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "trips",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 6, 4, 17, 13, 58, 278, DateTimeKind.Local).AddTicks(274), new DateTime(2020, 5, 28, 17, 13, 58, 278, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "GSxd25b+VBhXugATLd92/u9G77PgfkYf8dCq3EiWVKnuEIJ8IQ35XOcRQ3sWIY/V");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "0PyzM0fzzEn4EGnWQYD1CUwnBv1e8K3UVUpxh0baVbU911BB2PpBJruFxrJSGez1");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "7SrK7LW87QwtPRnJxVjtsTJjm9EBDFXoYZ9ou9IykQcNbdS5o2RxHRnL1EndiDuz");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "aO72N/xW/D2fkGQ2m/gO+TFcg6B3KrEbLmxFnKkRJlzcqPXUIy8/RtGr88jp0LX1");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "1Als9HTiAata9WbsyUgnRBvPWU3yzQ2MuGAYBACarlblKFfLYH8GkbaxQO032vUA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarFileName",
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
