using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using mahakBackend.Infrastructure.Data;
using System.Data;

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
            var SelectedUser = _DbContext.Users.FirstOrDefault(x => x.Id == user.Id);
            if (SelectedUser != null)
            {
                SelectedUser.Name = user.Name;
                SelectedUser.Email = user.Email;
                SelectedUser.UserCode = user.UserCode;
                SelectedUser.Group = user.Group;
                SelectedUser.Description = user.Description;
                SelectedUser.JoinDate = user.JoinDate;
                SelectedUser.LastActivity = user.LastActivity;
                SelectedUser.isAdded = user.isAdded;
                SelectedUser.imageId = user.imageId;
                SelectedUser.phoneNumber = user.phoneNumber;
                SelectedUser.isActive = user.isActive;
                _DbContext.SaveChanges();
            }
        }
    }
}
