using System;
using System.Collections.Generic;
using HealthOnion.Domain.Core;

namespace HealthOnion.Domain.Interfaces
{
    public interface IPatientRepository : IDisposable
    {
        IEnumerable<Patient> GetPatientList();
        Patient GetPatient(int id);
        void Create(Patient patient);
        void Update(Patient patient);
        void Delete(int id);
        void Save();
    }
}
