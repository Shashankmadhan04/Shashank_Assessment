using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lib.Core.Models
{
    public partial class API_InvestorsContext : DbContext
    {
        public API_InvestorsContext()
        {
        }

        public API_InvestorsContext(DbContextOptions<API_InvestorsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Investors> Investors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer("Server=LAPTOP-8GG8A8QO;Database=API_Investors;Integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Investors>(entity =>
            {
                entity.Property(e => e.Contact).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TotalInvestment)
                    .HasColumnName("Total_Investment")
                    .HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
