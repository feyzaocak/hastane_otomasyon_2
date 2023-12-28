using hastane_otomasyon_2.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using hastane_otomasyon_2.Data.Entity;

namespace hastane_otomasyon_2.Controllers
{
    [Authorize]//sadece login olan email görsün
        //yani sadece deneme@gmail.com burdaki sayfaları görebilecek.
    public class HomeController : Controller
    {
        public IActionResult RandevuAl()
        {
            // Tıbbi birimleri ve doktorları model üzerinden view'e gönder
            var model = new Randevu();
            // Tıbbi birimleri ve doktorları model üzerinden view'e gönder
            return View(model);
        }

        [HttpPost]
        public IActionResult RandevuAl(Randevu randevu)
        {
            // Randevu bilgilerini işle (veritabanına kaydet vb.)
            // Başarıyla işlendikten sonra bir yönlendirme yapabilirsin
            return RedirectToAction("Index", "Home");
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
          public IActionResult AnaSayfa()
    {
        return View();
    }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
       return RedirectToAction("Login","Home2");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
