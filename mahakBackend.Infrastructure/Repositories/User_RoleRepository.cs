using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using mahakBackend.Infrastructure.Data;

namespace mahakBackend.Infrastructure.Repositories
{
    public class User_RoleRepository : IUser_RoleRepository
    {
        private readonly MahakDbContext _DbContext;
        public User_RoleRepository(MahakDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public void Add(User_RoleEntity user_role)
        {
            _DbContext.UserRole.Add(user_role);
            _DbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var selectedUserRole = _DbContext.UserRole.FirstOrDefault(x => x.Id == id);
            if (selectedUserRole != null)
            {
                _DbContext.UserRole.Remove(selectedUserRole);
                _DbContext.SaveChanges();
            }
        }

        public IEnumerable<RoleEntity> GetRolesByUserId(int id)
        {
            return _DbContext.Roles.Where(
                u => _DbContext.UserRole.Any(x => x.RoleId == u.Id
                && _DbContext.Users.Any(y => y.Id == x.UserId && y.Id == id)
                )).ToList();
        }

        public IEnumerable<UserEntity> GetUsersByRoleId(int RoleId)
        {
            return _DbContext.Users.Where(
                u =>  _DbContext.UserRole.Any(
                    x => x.RoleId==RoleId && u.Id == x.UserId)).ToList();
        }
    }
}
