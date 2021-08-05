using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Seeding_HocVienDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HocViens",
                columns: new[] { "MaHV", "Email", "GioiTinh", "HoVaTen", "LopMaLop", "MaLop", "NgaySinh" },
                values: new object[] { 1, "NguynA@gmail.com", true, "Nguyễn Văn A", null, 1, new DateTime(2000, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "HocViens",
                columns: new[] { "MaHV", "Email", "GioiTinh", "HoVaTen", "LopMaLop", "MaLop", "NgaySinh" },
                values: new object[] { 2, "NguynB@gmail.com", true, "Nguyễn Văn B", null, 2, new DateTime(2001, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HocViens",
                keyColumn: "MaHV",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HocViens",
                keyColumn: "MaHV",
                keyValue: 2);
        }
    }
}
