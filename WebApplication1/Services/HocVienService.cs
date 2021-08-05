using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DbConTexts;
using WebApplication1.Entites;

namespace WebApplication1.Services
{
    public class HocVienService : IHocVienService
    {
        private readonly HocVienDbContext context;

        public HocVienService(HocVienDbContext context)
        {
            this.context = context;
        }
        public async Task<HocVien> CapNhat(HocVien hocVien)
        {
            try
            {
                context.Attach(hocVien);
                context.Entry<HocVien>(hocVien).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return hocVien;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<HocVien> ThemMoi(HocVien creatHocVien)
        {
            try
            {
                context.Add(creatHocVien);
                var maHV = await context.SaveChangesAsync();
                creatHocVien.MaHV = maHV;
                return creatHocVien;
            }
            catch (Exception)
            {

                throw;
            };
        }

        public async Task<HocVien> GetHocVienByMaHV(int MaHV)
        {
            return await context.HocViens.Include(l => l.Lop).FirstOrDefaultAsync(h => h.MaHV == MaHV);
        }

        public async Task<HocVien> KhoiPhuc(int maHV)
        {
            throw new NotImplementedException();
        }

        public async Task<HocVien> Xoa(int maHV)
        {
            throw new NotImplementedException();
        }

        //public HocVien Xoa(int maHV)
        //{
        //    try
        //    {
        //        var hocvien = GetHocVienByMaHV(maHV);
        //        context.HocViens.Remove(hocvien);
        //        context.Entry<Lop>
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
