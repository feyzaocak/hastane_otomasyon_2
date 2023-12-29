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
    public class KullaniciController : Controller
    {
        private readonly HastaneContext _context;


        public KullaniciController(HastaneContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var kullanicis = await _context.Kullanicis.ToListAsync();
            return View(kullanicis);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Kullanici model)
        {
            _context.Kullanicis.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var kull = await _context.Kullanicis.FindAsync(id);

            if (kull == null)
            {
                return NotFound();
            }

            return View(kull);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, Kullanici model)
        {
            if (id != model.KullaniciId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    if (!_context.Kullanicis.Any(o => o.KullaniciId == model.KullaniciId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }

                }
                return RedirectToAction("Index");

            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var kullanici = await _context.Kullanicis.FindAsync(id);

            if (kullanici == null)
            {
                return NotFound();
            }

            return View(kullanici);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            var kullanici = await _context.Kullanicis.FindAsync(id);
            if(kullanici ==null)
            {
                return NotFound();
            }
            _context.Kullanicis.Remove(kullanici);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}

