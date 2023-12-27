using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hastane_otomasyon_2.Data.Abstract
{
    public class Doktor
    {
        [Key]
        public int DoktorId { get; set; }

        public string? DoktorAdi { get; set; }

        public string? DoktorSoyadi { get; set; }


    }
}

