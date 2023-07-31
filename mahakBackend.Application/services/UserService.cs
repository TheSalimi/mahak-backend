using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using mahakBackend.Core.Domain.Iservice;

namespace mahakBackend.Core.Application.services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public void Add(UserEntity user)
        {
            _userRepository.Add(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public UserEntity GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Update(UserEntity user)
        {
            _userRepository.Update(user);
        }
    }
}
