using HealthOnion.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace HealthOnion.Infrastructure.Data
{
    public class PatientContext: DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options): base(options)
        {
        }
        public DbSet<User> Patients { get; set; }
    }
}
