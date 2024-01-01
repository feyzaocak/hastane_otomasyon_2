using hastane_otomasyon_2.Models;
using Microsoft.AspNetCore.Mvc;

public class TibbiBirimlerController : Controller
{
    public IActionResult Index()
    {
        var cerrahiBirimler = new List<TibbiBirimModel>
{
    new TibbiBirimModel { Id = 1, BirimAdi = "Genel Cerrahi", Aciklama = "Genel Cerrahi birimi" },
    new TibbiBirimModel { Id = 2, BirimAdi = "Kalp ve Damar Cerrahisi", Aciklama = "Kalp ve Damar Cerrahisi birimi" },
    new TibbiBirimModel { Id = 3, BirimAdi = "Beyin ve Sinir Cerrahisi", Aciklama = "Beyin ve Sinir Cerrahisi birimi" },
    new TibbiBirimModel { Id = 4, BirimAdi = "Göğüs Cerrahisi", Aciklama = "Göğüs Cerrahisi birimi" },
    new TibbiBirimModel { Id = 5, BirimAdi = "Ortopedi ve Travmatoloji", Aciklama = "Ortopedi ve Travmatoloji birimi" },
    new TibbiBirimModel { Id = 6, BirimAdi = "Üroloji", Aciklama = "Üroloji birimi" },
    new TibbiBirimModel { Id = 7, BirimAdi = "Plastik ve Rekonstrüktif Cerrahi", Aciklama = "Plastik ve Rekonstrüktif Cerrahi birimi" },
    new TibbiBirimModel { Id = 8, BirimAdi = "Çocuk Cerrahisi", Aciklama = "Çocuk Cerrahisi birimi" },
    new TibbiBirimModel { Id = 9, BirimAdi = "Mikrocerrahi", Aciklama = "Mikrocerrahi birimi" },
    new TibbiBirimModel { Id = 10, BirimAdi = "Gastroenteroloji Cerrahisi", Aciklama = "Gastroenteroloji Cerrahisi birimi" },
    new TibbiBirimModel { Id = 11, BirimAdi = "Plastik ve Estetik Cerrahi", Aciklama = "Plastik ve Estetik Cerrahi birimi" },
    new TibbiBirimModel { Id = 12, BirimAdi = "Nöroşirürji", Aciklama = "Nöroşirürji birimi" },
    new TibbiBirimModel { Id = 13, BirimAdi = "Endokrin Cerrahi", Aciklama = "Endokrin Cerrahi birimi" },
    new TibbiBirimModel { Id = 14, BirimAdi = "Cerrahi Onkoloji", Aciklama = "Cerrahi Onkoloji birimi" },
    new TibbiBirimModel { Id = 15, BirimAdi = "Plastik, Rekonstrüktif ve Estetik Cerrahi", Aciklama = "Plastik, Rekonstrüktif ve Estetik Cerrahi birimi" },
    new TibbiBirimModel { Id = 16, BirimAdi = "Göğüs Hastalıkları Cerrahisi", Aciklama = "Göğüs Hastalıkları Cerrahisi birimi" },
    new TibbiBirimModel { Id = 17, BirimAdi = "Girişimsel Radyoloji", Aciklama = "Girişimsel Radyoloji birimi" },
    new TibbiBirimModel { Id = 18, BirimAdi = "Kardiyovasküler Cerrahi", Aciklama = "Kardiyovasküler Cerrahi birimi" },
    new TibbiBirimModel { Id = 19, BirimAdi = "Transplantasyon Cerrahisi", Aciklama = "Transplantasyon Cerrahisi birimi" },
    new TibbiBirimModel { Id = 20, BirimAdi = "Göz Cerrahisi", Aciklama = "Göz Cerrahisi birimi" },
};


        var dahiliBirimler = new List<TibbiBirimModel>
{
    new TibbiBirimModel { Id = 11, BirimAdi = "Acil Tıp", Aciklama = "Acil Tıp birimi" },
    new TibbiBirimModel { Id = 12, BirimAdi = "Aile Hekimliği", Aciklama = "Aile Hekimliği birimi" },
    new TibbiBirimModel { Id = 13, BirimAdi = "Akupunktur", Aciklama = "Akupunktur birimi" },
    new TibbiBirimModel { Id = 14, BirimAdi = "Algoloji", Aciklama = "Algoloji birimi" },
    new TibbiBirimModel { Id = 15, BirimAdi = "Çocuk Endokrinoloji", Aciklama = "Çocuk Endokrinoloji birimi" },
    new TibbiBirimModel { Id = 16, BirimAdi = "Kardiyoloji", Aciklama = "Kardiyoloji birimi" },
    new TibbiBirimModel { Id = 17, BirimAdi = "Dermatoloji", Aciklama = "Dermatoloji birimi" },
    new TibbiBirimModel { Id = 18, BirimAdi = "Gastroenteroloji", Aciklama = "Gastroenteroloji birimi" },
    new TibbiBirimModel { Id = 19, BirimAdi = "Nefroloji", Aciklama = "Nefroloji birimi" },
    new TibbiBirimModel { Id = 20, BirimAdi = "Endokrinoloji", Aciklama = "Endokrinoloji birimi" },
    new TibbiBirimModel { Id = 21, BirimAdi = "Romatoloji", Aciklama = "Romatoloji birimi" },
    new TibbiBirimModel { Id = 22, BirimAdi = "Hematoloji", Aciklama = "Hematoloji birimi" },
    new TibbiBirimModel { Id = 23, BirimAdi = "Enfeksiyon Hastalıkları ve Klinik Mikrobiyoloji", Aciklama = "Enfeksiyon Hastalıkları ve Klinik Mikrobiyoloji birimi" },
    new TibbiBirimModel { Id = 24, BirimAdi = "Fiziksel Tıp ve Rehabilitasyon", Aciklama = "Fiziksel Tıp ve Rehabilitasyon birimi" },
    new TibbiBirimModel { Id = 25, BirimAdi = "Girişimsel Radyoloji", Aciklama = "Girişimsel Radyoloji birimi" },
    new TibbiBirimModel { Id = 26, BirimAdi = "Göğüs Hastalıkları", Aciklama = "Göğüs Hastalıkları birimi" },
    new TibbiBirimModel { Id = 27, BirimAdi = "İç Hastalıkları", Aciklama = "İç Hastalıkları birimi" },
    new TibbiBirimModel { Id = 28, BirimAdi = "Kadın Hastalıkları ve Doğum", Aciklama = "Kadın Hastalıkları ve Doğum birimi" },
    new TibbiBirimModel { Id = 29, BirimAdi = "Kardiyovasküler Cerrahi", Aciklama = "Kardiyovasküler Cerrahi birimi" },
    new TibbiBirimModel { Id = 30, BirimAdi = "Nöroloji", Aciklama = "Nöroloji birimi" },
    // Diğer dahili birimler buraya eklenebilir
};

        var disHekimligiBirimler = new List<TibbiBirimModel>
{
    new TibbiBirimModel { Id = 21, BirimAdi = "Ağız ve Diş Sağlığı", Aciklama = "Ağız ve Diş Sağlığı birimi" },
    new TibbiBirimModel { Id = 22, BirimAdi = "Ağız Diş ve Çene Cerrahisi", Aciklama = "Ağız Diş ve Çene Cerrahisi birimi" },
    new TibbiBirimModel { Id = 23, BirimAdi = "Çocuk Diş Hekimliği", Aciklama = "Çocuk Diş Hekimliği birimi" },
    new TibbiBirimModel { Id = 24, BirimAdi = "Endodonti", Aciklama = "Endodonti birimi" },
    new TibbiBirimModel { Id = 25, BirimAdi = "Ortodonti", Aciklama = "Ortodonti birimi" },
    new TibbiBirimModel { Id = 26, BirimAdi = "Periodontoloji", Aciklama = "Periodontoloji birimi" },
    new TibbiBirimModel { Id = 27, BirimAdi = "Protez Diş Hekimliği", Aciklama = "Protez Diş Hekimliği birimi" },
    new TibbiBirimModel { Id = 28, BirimAdi = "Ağız, Diş ve Çene Radyolojisi", Aciklama = "Ağız, Diş ve Çene Radyolojisi birimi" },
    // Diğer diş hekimliği birimleri buraya eklenebilir
};

        var laboratuvarBirimler = new List<TibbiBirimModel>
        {
            new TibbiBirimModel { Id = 31, BirimAdi = "Tıbbi Biyokimya", Aciklama = "Tıbbi Biyokimya birimi" },
            new TibbiBirimModel { Id = 32, BirimAdi = "Havacılık Tıp Merkezi", Aciklama = "Havacılık Tıp Merkezi birimi" },
            new TibbiBirimModel { Id = 33, BirimAdi = "Tıbbi Mikrobiyoloji", Aciklama = "Tıbbi Mikrobiyoloji birimi" },
            // Diğer laboratuvar birimleri buraya eklenebilir
        };

        var model = new Tuple<List<TibbiBirimModel>, List<TibbiBirimModel>, List<TibbiBirimModel>, List<TibbiBirimModel>>(
            cerrahiBirimler, dahiliBirimler, disHekimligiBirimler, laboratuvarBirimler);

        return View(model);
    }
}
