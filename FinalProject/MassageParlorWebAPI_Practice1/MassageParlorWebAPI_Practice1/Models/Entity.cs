using System.ComponentModel.DataAnnotations;

namespace MassageParlorWebAPI_Practice1.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
