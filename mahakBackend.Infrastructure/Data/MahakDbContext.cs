using mahakBackend.Core.Domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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

            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

                entity.Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();

                entity.Property(x => x.UserCode)
                .HasMaxLength(10);

                entity.Property(e => e.LastActivity)
                .HasColumnType("datetime");

                entity.Property(e => e.JoinDate)
                .HasColumnType("date");

                entity.Property(e => e.Group)
                .HasMaxLength(50);

                entity.Property(e => e.Description)
                .HasMaxLength(500);

                entity.Property(e => e.isAdded)
                .IsRequired();

                entity.Property(e => e.imageId)
                .HasColumnType("int");

                entity.Property(e => e.phoneNumber)
                .HasMaxLength(20);
            });
        }
    }
}
