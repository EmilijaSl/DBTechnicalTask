using Microsoft.EntityFrameworkCore;
using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Domain.Enums;

namespace NotificationSchedulingSystem.DAL
{
    public class SystemDbContext : DbContext
    {
        public DbSet<CompanyInformation> Company { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public SystemDbContext(DbContextOptions options) : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<CompanyInformation>()
                .Property(p => p.Type)
                .HasConversion(
                    c => c.ToString(),
                    c => (CompanyType)Enum.Parse(typeof(CompanyType), c)
                );
            modelBuilder
               .Entity<CompanyInformation>()
               .Property(p => p.Market)
               .HasConversion(
                   c => c.ToString(),
                   c => (Market)Enum.Parse(typeof(Market), c)
                        );

        }
    }
}
