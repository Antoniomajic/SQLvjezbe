namespace MassageParlor.Models
{
    public class Massage : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public ICollection<Appointment> Appointments { get; } = new List<Appointment>();
    }
}
