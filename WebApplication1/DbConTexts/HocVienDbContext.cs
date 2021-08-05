using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entites;

namespace WebApplication1.DbConTexts
{
    public class HocVienDbContext : DbContext
    {
        public HocVienDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<HocVien> HocViens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingLop(modelBuilder);
            SeedingHocVien(modelBuilder);
        }
        private void SeedingLop(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lop>().HasData(
                new Lop()
                {
                    MaLop = 1,
                    TenLop = "Tiếng Anh Cơ bản"
                },
                new Lop()
                {
                    MaLop = 2,
                    TenLop = "Tiếng Anh Nâng Cao"
                }
                );
        }
        private void SeedingHocVien(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HocVien>().HasData(
                new HocVien()
                {
                    MaHV = 1,
                    HoVaTen = "Nguyễn Văn A",
                    NgaySinh = new DateTime(2000,11,19),
                    GioiTinh = true,
                    Email = "NguynA@gmail.com",
                    MaLop = 1
                }, new HocVien()
                {
                    MaHV = 2,
                    HoVaTen = "Nguyễn Văn B",
                    NgaySinh = new DateTime(2001, 1, 9),
                    GioiTinh = true,
                    Email = "NguynB@gmail.com",
                    MaLop = 2
                }, 
                new HocVien()
                {
                    MaHV = 3,
                    HoVaTen = "Nguyễn Văn c",
                    NgaySinh = new DateTime(2001, 1, 9),
                    GioiTinh = true,
                    Email = "NguynC@gmail.com",
                    MaLop = 1
                }, 
                new HocVien()
                {
                    MaHV = 4,
                    HoVaTen = "Nguyễn Văn D",
                    NgaySinh = new DateTime(2001, 1, 9),
                    GioiTinh = true,
                    Email = "NguynD@gmail.com",
                    MaLop = 2
                }
                );
        }
    }
}
