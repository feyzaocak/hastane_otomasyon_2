
using System.ComponentModel.DataAnnotations;

namespace hastane_otomasyon_2.Models
{
    public class Doktor
    {
        public int Id { get; set; }

        [Required]
        public string AdSoyad { get; set; }

        [Required]
        public string UzmanlikAlani { get; set; }

       
    }
}
