using DNU_Library_website.BusinessObjects;
using DNU_Library_website.Models;
using Microsoft.EntityFrameworkCore;
using Umbraco.Cms.Core.Extensions;

namespace DNU_Library_website.DataAccess
{
    class LibDbContext : DbContext
    {
        public LibDbContext(DbContextOptions<LibDbContext> options)
       : base(options)
        {
        }

        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Article> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnStr.Get());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id");
                entity.Property(e => e.Name)
                    .HasColumnName("name");
                entity.Property(e => e.Description)
                .HasColumnName("description");
                entity.HasKey(e => e.Id);
                

            });
            modelBuilder.Entity<Article>(entity =>
            {

            }
            );
        }
    }
}