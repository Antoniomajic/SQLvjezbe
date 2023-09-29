using System.ComponentModel.DataAnnotations;

namespace MassageParlorWebAPI_Practice1.Models
{
    public class Massage : Entity
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        [Range(1,5000)]
        public int? Duration { get; set; }
        public decimal? Price { get; set; }
    }
}
