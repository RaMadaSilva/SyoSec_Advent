using Microsoft.EntityFrameworkCore;
using SyosecAdvent.Domain.Entities;
using System.Reflection;

namespace SyosecAdvent.Infrastructure.Data
{
    public class SyosecAdventDbContext : DbContext
    {
        public SyosecAdventDbContext(DbContextOptions<SyosecAdventDbContext> options)
            : base(options)
        {

        }

        public DbSet<Recommendation> Recommendations { get; set; } = null!; 
        public DbSet<Member> Members { get; set; } = null!;
        public DbSet<Church> Churchs { get; set; } = null!;
        public DbSet<User> Users { get; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
