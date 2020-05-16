using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Countries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Albania" },
                    { 2, "Canada" },
                    { 3, "Colombia" },
                    { 4, "Cyprus" },
                    { 5, "Dominica" },
                    { 6, "Egypt" },
                    { 7, "France" },
                    { 8, "Ukraine" }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -5,
                column: "Password",
                value: "LshVk5JSb49kQ7N+VOvXu680zCYlgmi7xvVqyekJ9Qn8Jk5AbR9unQ+DBLi5MJRA");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -4,
                column: "Password",
                value: "rxQLuMKgW7rksxOkAY0t5NNFhduDuuuPmBI9W8LXky5STiZakwy49yafh9alWRfx");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -3,
                column: "Password",
                value: "qujrA66Os5vU/VS1OhBSv0xTkzZZzyrlPfjNp+tDZp3NYWrn52n+WJ7I6awKY9v/");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -2,
                column: "Password",
                value: "lThbqsIUV2GzTsa4g716ocuBSsaYu0QW1PIcziBBxVX4fgYjcFjokedNOzJ9KmkR");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "978egret4cJPDGQ5B/UIAPTfNob4DxDsEBZmHyxK0m705w7gZsLLM1Stle18VhwT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "countries");

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
