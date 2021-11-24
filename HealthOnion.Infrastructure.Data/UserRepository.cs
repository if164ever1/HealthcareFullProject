using HealthOnion.Domain.Core;
using HealthOnion.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HealthOnion.Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext db;

        private bool disposed = false;

        public UserRepository(UserContext context)
        {
            this.db = context;
        }

        public void AddUserToRepository(User user)
        {
            this.db.Users.Add(user);
        }

        public void DeleteUserById(int id)
        {
            User patient = db.Users.Find(id);
            if (patient != null)
            {
                db.Users.Remove(patient);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this.db.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return this.db.Users.Find(id);
        }

        public void SaveUserToRepository()
        {
            this.db.SaveChanges();
        }

        public void UpdateUserRepository(User user)
        {
            this.db.Entry(user).State = EntityState.Modified;
        }
    }
}
