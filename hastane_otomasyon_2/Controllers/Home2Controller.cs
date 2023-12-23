using hastane_otomasyon_2.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace hastane_otomasyon_2.Controllers
{
    public class Home2Controller : Controller
    {
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Person personModel)
        {
            if (personModel.Email == "deneme@gmail.com" && personModel.Password == "1234-")
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, personModel.Email),
                    new Claim("Other Properties", "Example Role")
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = personModel.Oturum
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "user not found";
            return View();
        }
    }
}
