using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace MassageParlor.Models.DTO
{
    public class MassageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
    }
}
