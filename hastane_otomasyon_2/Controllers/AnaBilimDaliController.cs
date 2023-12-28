using Microsoft.AspNetCore.Mvc;
using hastane_otomasyon_2.Data.Entity;
using hastane_otomasyon_2.Data.efCore;
using Microsoft.EntityFrameworkCore;

namespace hastane_otomasyon_2.Controllers
{
    public class AnaBilimDaliController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
