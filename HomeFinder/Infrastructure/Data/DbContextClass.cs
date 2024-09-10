using HomeFinder.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeFinder.Infrastructure.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }

        public DbSet<QueryField> QueryFields { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContextClass).Assembly);
        }
    }
}
