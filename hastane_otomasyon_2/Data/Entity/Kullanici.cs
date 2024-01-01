using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hastane_otomasyon_2.Data.Entity
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }

        public string? KullaniciAdi { get; set; }

        public string? KullaniciSoyadi { get; set; }

        public string? KullaniciEmail { get; set; }

        public string? KullaniciTelefon { get; set; }

        public ICollection<Randevu> Randevus { get; set; } = new List<Randevu>();

    }
}

