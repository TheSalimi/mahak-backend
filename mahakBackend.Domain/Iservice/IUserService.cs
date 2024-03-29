﻿using mahakBackend.Core.Domain.entities;

namespace mahakBackend.Core.Domain.Iservice
{
    public interface IUserService
    {
        IEnumerable<UserEntity> GetAllUsers();
        UserEntity GetById(int id);
        void Add(UserEntity user);
        void Update(UserEntity user);
        void Delete(int id);
    }
}
