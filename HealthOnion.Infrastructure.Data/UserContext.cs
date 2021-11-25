using HealthOnion.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace HealthOnion.Infrastructure.Data
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options) :
            base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
