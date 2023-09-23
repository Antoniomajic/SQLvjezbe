using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    public class Grupa : Entitet
    {
        public string? Naziv { get; set; }
        [ForeignKey("smjer")] // pod navodnicima stavimo naziv vanjskog ključa (u ovom slučaju) u grupi
        public Smjer? Smjer { get; set; }
        public DateTime? DatumPocetka { get; set; }
        public List<Polaznik> Polaznici { get; set; } = new(); // da lista ne bude null ako nema polaznika, već da bude prazna(empty)
    }
}
