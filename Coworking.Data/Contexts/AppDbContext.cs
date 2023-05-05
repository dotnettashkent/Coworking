using Coworking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coworking.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Coworkingg> Coworkings { get; set; }
    }
}
