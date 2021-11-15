using HealthOnion.Domain.Core;
using HealthOnion.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthOnion.Infrastructure.Data
{
    class PatientRepository : IPatientRepository
    {
        private PatientContext db;
        private bool disposed = false;

        public PatientRepository()
        {
            this.db = new PatientContext();
        }
        
        public void Create(Patient patient)
        {
            this.db.Patients.Add(patient);
        }

        public void Delete(int id)
        {
            Patient patient = db.Patients.Find(id);
            if (patient != null)
            {
                db.Patients.Remove(patient);
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

        public Patient GetPatient(int id)
        {
            return this.db.Patients.Find(id);
        }

        public IEnumerable<Patient> GetPatientList()
        {
            return this.db.Patients.ToList();
        }

        public void Save()
        {
            this.db.SaveChanges();
        }

        public void Update(Patient patient)
        {
            this.db.Entry(patient).State = EntityState.Modified;
        }
    }
}
