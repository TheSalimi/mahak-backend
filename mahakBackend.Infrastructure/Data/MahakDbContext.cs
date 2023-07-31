using mahakBackend.Core.Domain.entities;
using Microsoft.EntityFrameworkCore;

namespace mahakBackend.Infrastructure.Data
{
    public class MahakDbContext : DbContext
    {
        public MahakDbContext(DbContextOptions<MahakDbContext> options) : base(options) { }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<User_RoleEntity> UserRole { get; set; }
    }
}
