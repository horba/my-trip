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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
