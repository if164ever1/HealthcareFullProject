using System;
using System.Collections.Generic;
using HealthOnion.Domain.Core;

namespace HealthOnion.Domain.Interfaces
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void AddUserToRepository(User user);
        void UpdateUserRepository(User user);
        void DeleteUserById(int id);
        void SaveUserToRepository();
    }
}
