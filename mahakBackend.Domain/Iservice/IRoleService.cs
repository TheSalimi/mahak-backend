using mahakBackend.Core.Domain.entities;

namespace mahakBackend.Core.Domain.Iservice
{
    public interface IRoleService
    {
        IEnumerable<RoleEntity> GetAllRoles();
        RoleEntity GetById(int id);
        void Add(RoleEntity role);
        Task Update(RoleEntity role);
        void Delete(int id);
    }
}
