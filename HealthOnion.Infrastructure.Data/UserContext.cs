using HealthOnion.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace HealthOnion.Infrastructure.Data
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
