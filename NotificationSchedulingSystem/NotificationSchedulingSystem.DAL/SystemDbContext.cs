using Microsoft.EntityFrameworkCore;
using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
       





    }
}
