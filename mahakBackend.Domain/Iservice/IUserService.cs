using mahakBackend.Core.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahakBackend.Core.Domain.Iservice
{
    public interface IUserService
    {
        Task<IEnumerable<UserEntity>> GetAllUsers();
        Task<UserEntity> GetById(int id);
        Task Add(UserEntity user);
        Task Update(UserEntity user);
        Task Delete(int id);
    }
}
