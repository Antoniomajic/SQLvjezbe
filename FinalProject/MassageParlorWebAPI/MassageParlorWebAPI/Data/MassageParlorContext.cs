using MassageParlorWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MassageParlorWebAPI.Data
{
    public class MassageParlorContext : DbContext
    {
        public MassageParlorContext(DbContextOptions<MassageParlorContext> opcije) : base(opcije)
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Massage> Massage { get; set; }
        
    }
}
