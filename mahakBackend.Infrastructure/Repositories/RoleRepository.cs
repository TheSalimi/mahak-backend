using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using mahakBackend.Infrastructure.Data;

namespace mahakBackend.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly MahakDbContext _DbContext;
        public RoleRepository(MahakDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public void Add(RoleEntity role)
        {
            _DbContext.Roles.Add(role);
            _DbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var selectedRole = _DbContext.Roles.FirstOrDefault(u => u.Id == id);
            if (selectedRole != null)
            {
                _DbContext.Roles.Remove(selectedRole);
                _DbContext.SaveChanges();
            }

        }

        public IEnumerable<RoleEntity> GetAllRoles()
        {
            return _DbContext.Roles.ToList();
        }

        public RoleEntity GetById(int id)
        {
            var selectedRole = _DbContext.Roles.FirstOrDefault(x => x.Id == id);
            return selectedRole;
        }

        public RoleEntity GetByName(string name)
        {
            var role = _DbContext.Roles.FirstOrDefault(x => x.Name == name);
            return role;
        }

        public void Update(RoleEntity role)
        {
            var SelectedRole = _DbContext.Roles.FirstOrDefault(x => x.Id == role.Id);
            if (SelectedRole != null)
            {
                SelectedRole.Name = role.Name;
                SelectedRole.IconId = role.IconId;
                SelectedRole.ColorId = role.ColorId;
                _DbContext.SaveChanges();
            }
        }
    }
}
