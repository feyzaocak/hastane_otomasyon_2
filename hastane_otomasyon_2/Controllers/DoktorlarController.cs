using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using hastane_otomasyon_2.Models;

public class DoktorlarController : Controller
{
    public IActionResult Index()
    {
        // Doktorları veritabanından al ve view'e gönder.
        List<Doktor> doktorlar = new List<Doktor>(); // Boş bir liste oluşturuyoruz. Veritabanından çekilecek.

        // Veritabanından doktorları çekme işlemi burada yapılacak.

        return View(doktorlar);
    }

    // Diğer action'lar...
}
