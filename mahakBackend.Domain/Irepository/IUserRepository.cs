using mahakBackend.Core.Domain.entities;

namespace mahakBackend.Core.Domain.Irepository
{
    public interface IUserRepository
    {
        IEnumerable<UserEntity> GetAllUsers();
        UserEntity GetById(int id);
        void Add(UserEntity user);
        void Update(UserEntity user);
        void Delete(int id);
    }
}
