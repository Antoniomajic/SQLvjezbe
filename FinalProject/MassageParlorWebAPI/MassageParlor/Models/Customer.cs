using System.ComponentModel.DataAnnotations;

namespace MassageParlor.Models
{
    public class Customer : Entity
    {
        [Required]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Contact { get; set; }
    }
}
