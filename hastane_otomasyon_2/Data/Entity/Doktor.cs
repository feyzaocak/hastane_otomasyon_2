using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using hastane_otomasyon_2.Data.Entity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hastane_otomasyon_2.Data.Entity
{
    public class Doktor
    {
        [Key]
        public int DoktorId { get; set; }

        public string? DoktorAdi { get; set; }

        public string? DoktorSoyadi { get; set; }
   
        [DisplayName("Alan Alanı:")]
        [ValidateNever]
        public int? AlanId { get; set; }

        [ForeignKey(("AlanId"))]
        [ValidateNever]
        public Alan Alan { get; set; }

        public string? AdSoyad
        {
            get
            {

                return this.DoktorAdi + " " +this.DoktorSoyadi;
            }

        }

    }
}