using mahakBackend.Core.Domain.entities;

namespace mahakBackend.Core.Domain.Irepository
{
    public interface IUser_RoleRepository
    {
        IEnumerable<RoleEntity> GetRolesByUserCode(long UserCode);
        IEnumerable<UserEntity> GetUsersByRoleId(int RoleId);
        void Add(User_RoleEntity user_role);
        void Delete(int id);
    }
}
