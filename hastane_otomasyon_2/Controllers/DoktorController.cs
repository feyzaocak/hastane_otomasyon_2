using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hastane_otomasyon_2.Data.Entity;
using hastane_otomasyon_2.Data.efCore;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hastane_otomasyon_2.Controllers
{
    public class DoktorContoroller : Controller
    {
        private readonly HastaneContext _context;


        public DoktorContoroller(HastaneContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var doktors = await _context.Doktors.ToListAsync();
            return View(doktors);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Doktor model)
        {
            _context.Doktors.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }
    }
}

