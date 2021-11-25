using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthOnion.Domain.Core;

namespace HealthOnion.Domain.Interfaces
{
    public interface IUserRepository : IDisposable
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        User GetUserById(int id);
        void AddUserToRepository(User user);
        void UpdateUserRepository(User user);
        void DeleteUserById(int id);
        void SaveUserToRepository();
    }
}
