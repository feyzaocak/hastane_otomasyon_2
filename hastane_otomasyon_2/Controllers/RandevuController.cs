using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hastane_otomasyon_2.Data.Entity;
using hastane_otomasyon_2.Data.efCore;
using Microsoft.EntityFrameworkCore;

namespace  hastane_otomasyon_2.Controllers
{

   public class RandevuController : Controller
    {

        private readonly HastaneContext _context;

        public  RandevuController(HastaneContext context)
        {

            _context = context;


        }
        public IActionResult Create ()
        {
            return View();
        }


    }

}