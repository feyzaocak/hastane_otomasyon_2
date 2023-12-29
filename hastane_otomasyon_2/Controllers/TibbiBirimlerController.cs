using Microsoft.AspNetCore.Mvc;
using hastane_otomasyon_2.Models;
using System.Collections.Generic;

public class TibbiBirimlerController : Controller
{
    public IActionResult Index()
    {
        // Örnek tıbbi birim verileri
        var tibbiBirimListesi = new List<TibbiBirimModel>
        {
            new TibbiBirimModel { Id = 1, BirimAdi = "Dahiliye", Aciklama = "İç hastalıklarıyla ilgilenen birim" },
            new TibbiBirimModel { Id = 2, BirimAdi = "Cerrahi", Aciklama = "Ameliyatlarla ilgilenen birim" },
            new TibbiBirimModel { Id = 3, BirimAdi = "Göz Hastalıkları", Aciklama = "Göz hastalıklarıyla ilgilenen birim" }
            // ... diğer birimler
        };

        return View(tibbiBirimListesi);
    }
}
