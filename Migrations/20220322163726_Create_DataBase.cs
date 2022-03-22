using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenVanCuong56022.Migrations
{
    public partial class Create_DataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityNVC56022",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityNVC56022", x => x.UniversityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityNVC56022");
        }
    }
}
