using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using mahakBackend.Core.Domain.Iservice;

namespace mahakBackend.Core.Application.services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository RoleRepository)
        { 
            _roleRepository = RoleRepository;
        }
        public void Add(RoleEntity role)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleEntity> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public RoleEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(RoleEntity role)
        {
            throw new NotImplementedException();
        }
    }
}
