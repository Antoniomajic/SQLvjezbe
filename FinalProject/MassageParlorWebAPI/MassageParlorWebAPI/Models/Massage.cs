using System.ComponentModel.DataAnnotations;

namespace MassageParlorWebAPI.Models
{
    public class Massage : Entity
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
    }
}
