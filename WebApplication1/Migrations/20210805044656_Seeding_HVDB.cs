using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Seeding_HVDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HocViens",
                columns: new[] { "MaHV", "Email", "GioiTinh", "HoVaTen", "LopMaLop", "MaLop", "NgaySinh" },
                values: new object[] { 3, "NguynC@gmail.com", true, "Nguyễn Văn c", null, 1, new DateTime(2001, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "HocViens",
                columns: new[] { "MaHV", "Email", "GioiTinh", "HoVaTen", "LopMaLop", "MaLop", "NgaySinh" },
                values: new object[] { 4, "NguynD@gmail.com", true, "Nguyễn Văn D", null, 2, new DateTime(2001, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HocViens",
                keyColumn: "MaHV",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HocViens",
                keyColumn: "MaHV",
                keyValue: 4);
        }
    }
}
