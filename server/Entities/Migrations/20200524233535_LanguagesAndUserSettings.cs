using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class LanguagesAndUserSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Russian" },
                    { 3, "Ukrainian" }
                });

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
                columns: new[] { "LastName", "Password" },
                values: new object[] { "Last5", "qqUO4C0l9uuRrFuZemahbGlYAleg5c/uZsH1/i3ce2mkKLRZ414/fUX91OIJB5fH" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { "LongFirstName4", 2, "LongLastName4", "IC4+slE3NE+hY4dXpzySnPpbbM39rqdVOnkkk1qVu1cgNqfYPPP5w5rvOgnK3br9" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { "FFFF3", 3, "LLLL3", "T1H29Rht3ksZtIAgU6W9x+Ibeb+bcay4TJxkzOeYW2zY68ZYiFKY++RGf2CtUEI8" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { "FirstName2", 2, "LastName2", "XQDy8chHqNJQuE0llLEQ4ArXEfvOFkBlbK6apb9g3CsmrlhFmNRjMbUEl831OXmu" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "FirstName", "LastName", "Password" },
                values: new object[] { "Fn1", "Ln1", "H5pVqpkivaTDpPJL3hEznscqDJ13j4vF1ri5UFxIXfUG9ZzmxCim3uNdh9lgpm2B" });

            migrationBuilder.CreateIndex(
                name: "IX_users_CountryId",
                table: "users",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_users_LanguageId",
                table: "users",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_countries_CountryId",
                table: "users",
                column: "CountryId",
                principalTable: "countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_users_languages_LanguageId",
                table: "users",
                column: "LanguageId",
                principalTable: "languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_countries_CountryId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_languages_LanguageId",
                table: "users");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropIndex(
                name: "IX_users_CountryId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_LanguageId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "Country",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "LastName", "Password" },
                values: new object[] { null, "a8APt+FH76oSxud6xByXF80/9EEw3Md/rZ/Rh9/plZtnRd75zKHPUh1Y0Fmc+Xrg" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Country", "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { 2, null, 0, null, "h1sk1rNrmMXAf0vXAGf+fU8YPLqop2kOQaRTQ4HWx1+w034u6Gt16nfgWNNArV5f" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Country", "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { 2, null, 0, null, "9kQ0AnWvFManewW+MD4WpDnYhbhQ3PmWCGBiAbzgSoJLqK0EbGstl5YpWNGO5Pus" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Country", "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { 1, null, 0, null, "7JX8jQHqx1hd4HUMnBKbYO7ihBeVMl8jngm6qVXomOJx2xAlm1IuzXS5nLyGtIe1" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Country", "FirstName", "LastName", "Password" },
                values: new object[] { 3, null, null, "r5AcRG+U3Yi5olP/rcToFJwKu2KH4PB6NJ99/fPCE8cp6SnyHWbir79TnanNAeVI" });
        }
    }
}
