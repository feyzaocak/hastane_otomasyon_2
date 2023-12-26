using hastane_otomasyon_2.Models;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(UserModel userModel)
    {
        // Burada userModel verilerini işleyebilir ve üyeyi kaydedebilirsiniz.
        // Örneğin, veritabanına kaydedebilir veya başka bir depolama mekanizması kullanabilirsiniz.
        // Daha sonra giriş sayfasına yönlendirebilirsiniz.
        return RedirectToAction("Login", "Home2");
    }
}
