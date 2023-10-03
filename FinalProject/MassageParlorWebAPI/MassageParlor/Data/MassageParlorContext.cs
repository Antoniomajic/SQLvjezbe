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
        public DbSet<Massage> Massage { get; set; }
        public DbSet<Appointment> Appointment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasOne(a => a.Customer);

            modelBuilder.Entity<Appointment>().HasMany(a => a.Massages).WithMany(m => m.Appointments).UsingEntity<Dictionary<string, object>>("appointment_massage",
                am => am.HasOne<Massage>().WithMany().HasForeignKey("massage"),
                am => am.HasOne<Appointment>().WithMany().HasForeignKey("appointment"),
                am => am.ToTable("appointment_massage")
                );
        }
    }
}
