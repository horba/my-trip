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
                columns: new[] { "Country", "FirstName", "Language", "LastName", "Password" },
                values: new object[] { 3, "First5", 2, "Last5", "3ILzrBfqh9jiW/MXzCnrcJb6su2fKHK3YKJrDh8gJe3YBzzoRDg6z5Cd4ArueM5f" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Country", "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { 1, "LongFirstName4", 1, "LongLastName4", "ntkVOkoRXx9HsA11wPqw6JjYSQ/1K02psibRR3+lTZaL1mWgB2bFqbi93p6IlJej" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Country", "FirstName", "Gender", "Language", "LastName", "Password" },
                values: new object[] { 1, "FFFF3", 2, 1, "LLLL3", "brLwfLObHtt4nSPbYV9F9ny8SAp9EQmzmqo0SrQA1n45OwTtGyb+JEC+7Du28/2P" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { "FirstName2", 1, "LastName2", "APQonDLtkfTx8LjAq/h3EKjIofprGeOeqIqbzbj7+l6nwlbrPPsPYLxTg3W1is+e" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Country", "FirstName", "Language", "LastName", "Password" },
                values: new object[] { 2, "Fn1", 3, "Ln1", "y69sD36qZyBUUSRiI7l8rlk038JRgWao2P60v106CgGBEYCHslsmjo4a4PzIY+Cg" });
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
