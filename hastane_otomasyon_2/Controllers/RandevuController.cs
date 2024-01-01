using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hastane_otomasyon_2.Data.Entity;
using hastane_otomasyon_2.Data.efCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;

namespace  hastane_otomasyon_2.Controllers
{

    public class RandevuController : Controller
    {

        private readonly HastaneContext _context;

        public RandevuController(HastaneContext context)
        {

            _context = context;


        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {

            ViewBag.Alans = new SelectList(await _context.Alans.ToListAsync(), "AlanId", "AlanAdı");
            ViewBag.Doktors = new SelectList(await _context.Doktors.ToListAsync(), "DoktorId", "AdSoyad");
            ViewBag.Randevus = new SelectList(await _context.Randevus.ToListAsync(), "RandevuId", "RandevuTarihi");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Randevu model)
        {
            
            _context.Randevus.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }



    }
}