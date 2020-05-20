using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class UserSettingsMockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Country",
                table: "users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Language", "LastName", "Password" },
                values: new object[] { 2, "Last5", "l/Xw4PpHfKbLQZDCG9cjzPkVqxb1SFSCKy/Dgq8kAWhDJXcEHVvJaDnQoPY6PiDZ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Country", "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { 2, "LongFirstName4", 2, "LongLastName4", "eePej1CqKBZ6Id36WWmiPP9eF30dPvBu6BvQJdha08e0WH3/24mqFvFNHTPYpam1" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Country", "FirstName", "Gender", "Language", "LastName", "Password" },
                values: new object[] { 2, "FFFF3", 3, 1, "LLLL3", "6lLrFyf6gplT1VJH/tXjc6EkYqwbyBQMaRppE6IaF7xWJd3ekNnMIoYHmuHY/l2D" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Country", "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { 1, "FirstName2", 2, "LastName2", "QV0YR2Pv6MtOVTS/sSLN+v2zPOl0gyAZUxG6Btu/i7Xz9hMecMGFujOrBg5ZUGlX" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Country", "FirstName", "Language", "LastName", "Password" },
                values: new object[] { 3, "Fn1", 3, "Ln1", "83x1MpGkCOw7x3Jzb9CVHcI6VbyxeZ99bXOZys2XLD0YfQTnUBuzQyf/Vj6shZFx" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "users");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "QGHv9Ph5Zs4Wamckp35z1tCgyknOdWwKzslA85YfJCPvONI994pAhF12LX4gdAbt");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "nFIQsPpOx+YiLz/v0KfbDG4VSsmAiPZyf5nvpfyztO9EZqAyXfkv421amL9TymAE");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "MFUC0Wjm2iYvRI/rNJRBzQb+8/AHsN3GqLTkXj3UbPKxUwLgn3IsdNX3SplbVFHu");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "pRpBVq2mZq/sFyneP5hfP9IfXdLxwcWqFddpI3Mksa30Qv5+l76BsbLoPyTsYJsr");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "0cy6qRLzxD3QlIuWRAgJglhK4naCwK1khtMXYUrocy4R7A98IFvyJgGS0u0rQuU2");
        }
    }
}
