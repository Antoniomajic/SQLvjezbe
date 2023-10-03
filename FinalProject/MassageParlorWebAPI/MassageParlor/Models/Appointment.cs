using System.ComponentModel.DataAnnotations.Schema;

namespace MassageParlor.Models
{
    public class Appointment : Entity
    {
        public DateTime DateAndTime { get; set; }
        [ForeignKey("customer")]
        public Customer? Customer { get; set; } // foreign key
        public List<Massage> Massages { get; set; } = new();
    }
}
