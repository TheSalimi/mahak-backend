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
