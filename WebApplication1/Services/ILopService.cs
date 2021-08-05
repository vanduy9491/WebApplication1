using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entites;

namespace WebApplication1.Services
{
    public interface ILopService
    {
        Task<List<Lop>> GetLops();
        Task<Lop> GetLopByMaLop(int MaLop);
    }
}
