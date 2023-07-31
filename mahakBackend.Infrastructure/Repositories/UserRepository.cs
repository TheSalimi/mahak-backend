using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using mahakBackend.Infrastructure.Data;

namespace mahakBackend.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MahakDbContext _DbContext;
        public UserRepository(MahakDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public void Add(UserEntity user)
        {
            _DbContext.Users.Add(user);
            _DbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _DbContext.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _DbContext.Users.Remove(user);
                _DbContext.SaveChanges();
            }
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            return _DbContext.Users.ToList();   
        }

        public UserEntity GetById(int id)
        {
            return _DbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Update(UserEntity user)
        {
            _DbContext.Users.Update(user);
            _DbContext.SaveChanges();
        }
    }
}
