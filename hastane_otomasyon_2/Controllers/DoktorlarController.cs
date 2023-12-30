using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hastane_otomasyon_2.Data.Entity;
using hastane_otomasyon_2.Data.efCore;
using Microsoft.EntityFrameworkCore;

namespace hastane_otomasyon_2.Controllers
{
    public class DoktorlarController : Controller
    {
        private readonly HastaneContext _context;

        public DoktorlarController(HastaneContext context)
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

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var doc = await _context.Doktors.FindAsync(id);

            if (doc == null)
            {
                return NotFound();
            }

            return View(doc);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Doktor model)
        {
            if (id != model.DoktorId)
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
                    if (!_context.Doktors.Any(o => o.DoktorId == model.DoktorId))
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
            var doktor = await _context.Doktors.FindAsync(id);

            if (doktor == null)
            {
                return NotFound();
            }

            return View(doktor);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            var doktor = await _context.Doktors.FindAsync(id);
            if (doktor == null)
            {
                return NotFound();
            }
            _context.Doktors.Remove(doktor);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
