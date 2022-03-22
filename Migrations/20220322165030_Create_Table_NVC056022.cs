using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenVanCuong56022.Migrations
{
    public partial class Create_Table_NVC056022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NVC056022",
                columns: table => new
                {
                    NVCID = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NVCName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    NVCGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NVC056022", x => x.NVCID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NVC056022");
        }
    }
}
