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
            _roleRepository.Add(role);
        }

        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }

        public IEnumerable<RoleEntity> GetAllRoles()
        {
            return _roleRepository.GetAllRoles();
        }

        public RoleEntity GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public RoleEntity GetByName(string name)
        {
            return _roleRepository.GetByName(name);
        }

        public void Update(RoleEntity role)
        {
            _roleRepository.Update(role);
        }
    }
}
