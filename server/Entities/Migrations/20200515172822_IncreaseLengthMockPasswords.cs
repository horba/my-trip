using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class IncreaseLengthMockPasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "6f2BX2AFu7Me7zg5PLfPj/zZxndZYi05+btyZ1DPYiJcfvwYn+j4+LB29rqb4IYS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "AkcieaUZvile78XDpN8+XD3JKsmKKmrwuWPuRl5SEBJqqkwu/ZISVgxJZgRRH5RE");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "skmRAX40jXIsx0doAOE1eDH9C48ZKbgBi9pAn0f1jUnJl7iJ91TI4/o1S+8hJxwF");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "8IfxrRQwpbu+tUzLRNo3uXnyiNrDuJRcG1tLJimSeCnF2RqdGUO6w62PJJFD+IEV");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "d53tbpepSAOL9x9Xo2ea/LLhaJSgmyO0CCXFrYcdk66s3icf5o3lPGejbtagCjdD");
        }
    }
}
