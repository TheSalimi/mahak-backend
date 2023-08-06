using mahakBackend.Core.Domain.entities;

namespace mahakBackend.Core.Domain.Iservice
{
    public interface IRoleService
    {
        IEnumerable<RoleEntity> GetAllRoles();
        RoleEntity GetById(int id);
        RoleEntity GetByName(string name);
        void Add(RoleEntity role);
        void Update(RoleEntity role);
        void Delete(int id);
    }
}
