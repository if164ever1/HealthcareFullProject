using HealthOnion.Domain.Core;
using System.Data.Entity;

namespace HealthOnion.Infrastructure.Data
{
    public class PatientContext: DbContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}
