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
            var selectedRole = _DbContext.Roles.FirstOrDefault(x=>x.Id == id);
            return selectedRole;
        }

        public void Update(RoleEntity role)
        {
            _DbContext.Roles.Update(role);
            _DbContext.SaveChanges();
        }
    }
}
