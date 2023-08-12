using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using mahakBackend.Core.Domain.Iservice;

namespace mahakBackend.Core.Application.services
{
    public class User_RoleService : IUser_RoleService
    {
        IUser_RoleRepository _user_roleRepository { get; set; }
        public User_RoleService(IUser_RoleRepository user_RoleRepository) 
        { 
            _user_roleRepository = user_RoleRepository;
        }

        public void Add(User_RoleEntity user_role)
        {
            _user_roleRepository.Add(user_role);
        }

        public void Delete(int id)
        {
            _user_roleRepository.Delete(id);
        }

        public IEnumerable<RoleEntity> GetRolesByUserId(int id)
        {
            return _user_roleRepository.GetRolesByUserId(id);
        }

        public IEnumerable<UserEntity> GetUsersByRoleId(int RoleId)
        {
            return _user_roleRepository.GetUsersByRoleId(RoleId);
        }

        public IEnumerable<User_RoleEntity> GetAllUserRoles()
        {
            return _user_roleRepository.GetAllUserRoles();
        }
    }
}
