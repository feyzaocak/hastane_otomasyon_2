using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hastane_otomasyon_2.Data.Entity
{
    public class Alan
    {
        [Key]
        public int AlanId { get; set; }

        public string? AlanAdı { get; set; }


    }
}

