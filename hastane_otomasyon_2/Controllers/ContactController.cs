﻿// ContactController.cs
using Microsoft.AspNetCore.Mvc;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(ContactFormModel contactForm)
    {
        // İletişim formu gönderildiğinde burada işlemler yapılabilir.
        // Örneğin, e-posta gönderme veya veritabanına kaydetme gibi.
        // Ardından teşekkür mesajı içeren bir görünüme yönlendirilebilir.
        return View("ThankYou");
    }
}
