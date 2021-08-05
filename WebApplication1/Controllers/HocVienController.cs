using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.HocVien;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HocVienController : Controller
    {
        private static int maLop;
        private static string tenLop;
        private readonly ILopService lopService;
        private readonly IHocVienService hocVienService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HocVienController(ILopService lopService, 
                                IHocVienService hocVienService,
                                IWebHostEnvironment webHostEnvironment)
        {
            this.lopService = lopService;
            this.hocVienService = hocVienService;
            this.webHostEnvironment = webHostEnvironment;
        }
        [Route("/HocVien/Index/{ml}")]
        public async Task<IActionResult> Index(int ml)
        {
            maLop = ml;
            var lop = await lopService.GetLopByMaLop(ml);
            tenLop = lop.TenLop;
            return View(lop);
        }
    }
}
