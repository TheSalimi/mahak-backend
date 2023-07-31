using mahakBackend.Core.Domain.entities;

namespace mahakBackend.Core.Domain.Irepository
{
    public interface IRoleRepository
    {
        IEnumerable <RoleEntity> GetAllRoles();
        RoleEntity GetById(int id);
        void Add(RoleEntity role);
        void Update(RoleEntity role);
        void Delete(int id);
    }
}
