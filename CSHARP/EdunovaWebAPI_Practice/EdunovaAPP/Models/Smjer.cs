using System.ComponentModel.DataAnnotations;

namespace EdunovaAPP.Models
{
    public class Smjer : Entitet
    {
        [Required]
        public string? Naziv { get; set; }
        [Required] // ovo stavimo da se ne bi baza bunila kada obrišemo stavke na swaggeru(?)
        [Range(30,500)]
        public int Trajanje { get; set; }
        public decimal? Cijena { get; set; }
        public decimal? Upisnina { get; set; }
        public bool? Verificiran { get; set; }
    }
}
