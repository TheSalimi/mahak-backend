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
            modelBuilder.Entity<User_RoleEntity>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired(false);


            modelBuilder.Entity<User_RoleEntity>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired(false);
        }
    }
}
