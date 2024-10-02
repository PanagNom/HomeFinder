using HomeFinder.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HomeFinder.Infrastructure.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigration(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            using DbContextClass dbContext = scope.ServiceProvider.GetRequiredService<DbContextClass>();

            dbContext.Database.Migrate();
        }
    }
}
