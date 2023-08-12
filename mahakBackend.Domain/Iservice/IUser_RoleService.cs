using mahakBackend.Core.Domain.entities;

namespace mahakBackend.Core.Domain.Iservice
{
    public interface IUser_RoleService
    {
        IEnumerable<RoleEntity> GetRolesByUserId(int id);
        IEnumerable<UserEntity> GetUsersByRoleId(int RoleId);
        IEnumerable<User_RoleEntity> GetAllUserRoles();
        void Add(User_RoleEntity user_role);
        void Delete(int id);
    }
}
