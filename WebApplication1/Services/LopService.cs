using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DbConTexts;
using WebApplication1.Entites;

namespace WebApplication1.Services
{
    public class LopService : ILopService
    {
        private readonly HocVienDbContext context;
        public LopService(HocVienDbContext context)
        {
            this.context = context;
        }

        public async Task<Lop> GetLopByMaLop(int MaLop)
        {
            return await context.Lops.Include(l => l.HocViens).FirstOrDefaultAsync(h => h.MaLop == MaLop);
        }

        public async Task<List<Lop>> GetLops()
        {
            return await context.Lops.Include(l => l.HocViens).ToListAsync();
        }
    }
}
