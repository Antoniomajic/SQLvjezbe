using MassageParlor.Models;
using Microsoft.EntityFrameworkCore;

namespace MassageParlor.Data
{
    public class MassageParlorContext : DbContext
    {
        public MassageParlorContext(DbContextOptions<MassageParlorContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
    }
}
