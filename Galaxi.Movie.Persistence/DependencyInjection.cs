using Galaxi.Movie.Persistence.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Galaxi.Movie.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MovieContextDb>(options =>
                options.UseSqlServer(
                    configuration["connectionStrings:MoviesEntities"] ?? string.Empty,
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.MigrationsAssembly(typeof(MovieContextDb).Assembly.FullName);
                        sqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 10,
                            maxRetryDelay: TimeSpan.FromSeconds(10),
                            errorNumbersToAdd: null
                        );
                    }));
            services.AddScoped<IMovieContextDb>(provider => provider.GetRequiredService<MovieContextDb>());
            return services;
        }
    }
}
