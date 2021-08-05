using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Lops;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class LopController : Controller
    {
        private readonly ILopService lopService;

        public LopController(ILopService lopService)
        {
            this.lopService = lopService;
        }
        public async Task<IActionResult> Index()
        {
            var lops = await lopService.GetLops();
            var xemLop = new XemDanhSachLop()
            {
                Lops = lops.ToList()
            };
            return View(xemLop);
        }
    }
}
