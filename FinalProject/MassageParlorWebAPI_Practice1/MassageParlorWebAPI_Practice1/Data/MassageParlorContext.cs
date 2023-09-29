using MassageParlorWebAPI_Practice1.Models;
using Microsoft.EntityFrameworkCore;

namespace MassageParlorWebAPI_Practice1.Data
{
    public class MassageParlorContext : DbContext
    {
        public MassageParlorContext(DbContextOptions<MassageParlorContext> options) : base(options)
        {

        }

        public DbSet<Massage> Massage { get; set; }


    }
}
