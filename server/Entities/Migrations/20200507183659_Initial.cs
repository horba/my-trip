using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { -1, "test1@users.com", "d53tbpepSAOL9x9Xo2ea/LLhaJSgmyO0CCXFrYcdk66s3icf5o3lPGejbtagCjdD" },
                    { -2, "test2@users.com", "8IfxrRQwpbu+tUzLRNo3uXnyiNrDuJRcG1tLJimSeCnF2RqdGUO6w62PJJFD+IEV" },
                    { -3, "test3@users.com", "skmRAX40jXIsx0doAOE1eDH9C48ZKbgBi9pAn0f1jUnJl7iJ91TI4/o1S+8hJxwF" },
                    { -4, "test4@users.com", "AkcieaUZvile78XDpN8+XD3JKsmKKmrwuWPuRl5SEBJqqkwu/ZISVgxJZgRRH5RE" },
                    { -5, "test5@users.com", "6f2BX2AFu7Me7zg5PLfPj/zZxndZYi05+btyZ1DPYiJcfvwYn+j4+LB29rqb4IYS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
