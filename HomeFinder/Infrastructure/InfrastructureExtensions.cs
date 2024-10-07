using Domain.Interfaces;
using HomeFinder.Domain.Interfaces;
using HomeFinder.Infrastructure.Repositories;

namespace HomeFinder.Infrastructure
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services
                .AddScoped<IQueryFieldRepository, QueryFieldRepository>()
                .AddScoped<IHouseRepository, HouseRepository>()
                .AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
