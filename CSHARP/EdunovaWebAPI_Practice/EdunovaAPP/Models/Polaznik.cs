namespace EdunovaAPP.Models
{
    public class Polaznik : Entitet
    {
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Oib { get; set; }
        public string? Email { get; set; }
        public ICollection<Grupa> Grupe { get; } = new List<Grupa>(); // sa lijeve strane se nalazi sučelje, a sa desne strane je implementacijska klasa
    }
}