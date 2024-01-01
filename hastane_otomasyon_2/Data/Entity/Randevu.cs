using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hastane_otomasyon_2.Data.Entity
{
    public class Randevu
    {
        [Key]
        public int RandevuId { get; set; }

        public string? RandevuAdi { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd",ApplyFormatInEditMode =true)]
        public DateTime RandevuTarihi { get; set; }

        [ForeignKey("AlanId")]
        [ValidateNever]

        public int? AlanId { get; set; }
        public Alan Alan { get; set; } = null!;

        [ForeignKey("KullaniciId")]
        [ValidateNever]
        public int? KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; } = null!;

        [ForeignKey("DoktorId")]
        [ValidateNever]
        public int? DoktorId { get; set; }
        public Doktor Doktor { get; set; } = null!;


    }
}

