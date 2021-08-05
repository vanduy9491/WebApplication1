using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Seeding_LopDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lops",
                columns: new[] { "MaLop", "TenLop" },
                values: new object[] { 1, "Tiếng Anh Cơ bản" });

            migrationBuilder.InsertData(
                table: "Lops",
                columns: new[] { "MaLop", "TenLop" },
                values: new object[] { 2, "Tiếng Anh Nâng Cao" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "MaLop",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "MaLop",
                keyValue: 2);
        }
        
    }
}
