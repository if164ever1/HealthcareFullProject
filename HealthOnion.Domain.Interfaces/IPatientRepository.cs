using System;
using System.Collections.Generic;
using HealthOnion.Domain.Core;

namespace HealthOnion.Domain.Interfaces
{
    public interface IPatientRepository : IDisposable
    {
        IEnumerable<User> Patients();
        User GetPatient(int id);
        void Create(User patient);
        void Update(User patient);
        void Delete(int id);
        void Save();
    }
}
