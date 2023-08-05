using mahakBackend.Core.Domain.entities;

namespace mahakBackend.Core.Domain.Iservice
{
    public interface IUser_RoleService
    {
        IEnumerable<RoleEntity> GetRolesByUserCode(string UserCode);
        IEnumerable<UserEntity> GetUsersByRoleId(int RoleId);
        void Add(User_RoleEntity user_role);
        void Delete(int id);
    }
}
