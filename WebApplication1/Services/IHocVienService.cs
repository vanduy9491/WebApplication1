using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entites;

namespace WebApplication1.Services
{
    public interface IHocVienService
    {
        Task<HocVien> ThemMoi(HocVien creatHocVien);
        Task<HocVien> GetHocVienByMaHV(int MaHV);
        Task<HocVien> CapNhat(HocVien hocVien);
        Task<HocVien> Xoa(int maHV);
        Task<HocVien> KhoiPhuc(int maHV);
    }
}
