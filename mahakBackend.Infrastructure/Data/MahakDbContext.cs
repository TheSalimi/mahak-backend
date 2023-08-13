using mahakBackend.Core.Domain.entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace mahakBackend.Infrastructure.Data
{
    public class MahakDbContext : DbContext
    {
        public MahakDbContext(DbContextOptions<MahakDbContext> options) : base(options) { }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<User_RoleEntity> UserRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleEntity>(entity =>
            {
                entity.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

                entity.Property(x => x.IconId)
                .HasColumnType("tinyint");

                entity.Property(x => x.ColorId)
                .HasColumnType("tinyint");
            });
        }
    }
}
