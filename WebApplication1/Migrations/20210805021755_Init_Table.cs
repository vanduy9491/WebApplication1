using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Init_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    MaLop = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.MaLop);
                });

            migrationBuilder.CreateTable(
                name: "HocViens",
                columns: table => new
                {
                    MaHV = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoVaTen = table.Column<string>(maxLength: 40, nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    GioiTinh = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    MaLop = table.Column<int>(nullable: false),
                    LopMaLop = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocViens", x => x.MaHV);
                    table.ForeignKey(
                        name: "FK_HocViens_Lops_LopMaLop",
                        column: x => x.LopMaLop,
                        principalTable: "Lops",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HocViens_LopMaLop",
                table: "HocViens",
                column: "LopMaLop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HocViens");

            migrationBuilder.DropTable(
                name: "Lops");
        }
    }
}
