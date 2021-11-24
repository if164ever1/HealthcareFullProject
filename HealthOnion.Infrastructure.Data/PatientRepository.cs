using HealthOnion.Domain.Core;
using HealthOnion.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthOnion.Infrastructure.Data
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientContext db;

        private bool disposed = false;

        public PatientRepository(PatientContext context)
        {
            this.db = context;
        }
        
        public void Create(User patient)
        {
            this.db.Patients.Add(patient);
        }

        public void Delete(int id)
        {
            User patient = db.Patients.Find(id);
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

        public User GetPatient(int id)
        {
            return this.db.Patients.Find(id);
        }

        public IEnumerable<User> Patients()
        {
            return this.db.Patients.ToList();
        }

        public void Save()
        {
            this.db.SaveChanges();
        }

        public void Update(User patient)
        {
            this.db.Entry(patient).State = EntityState.Modified;
        }
    }
}
