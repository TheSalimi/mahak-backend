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
