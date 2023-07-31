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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleEntity> GetRolesByUserCode(long UserCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserEntity> GetUsersByRoleId(int RoleId)
        {
            throw new NotImplementedException();
        }

        public void Update(User_RoleEntity user_role)
        {
            throw new NotImplementedException();
        }
    }
}
