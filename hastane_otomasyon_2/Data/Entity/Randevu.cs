using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hastane_otomasyon_2.Data.Entity
{
    public class Randevu
    {
        [Key]
        public int RandevuId { get; set; }

        public string? RandevuAdi { get; set; }

        public int KullaniciId { get; set; }

        public int AlanId { get; set; }

        public int  DoktorId { get; set; }

        public DateTime RandevuTarihi { get; set; }

    }
}

