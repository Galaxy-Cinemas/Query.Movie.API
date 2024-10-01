using Galaxi.Movie.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Galaxi.Movie.Persistence.Persistence
{
    public class MovieContextDb : DbContext, IMovieContextDb
    {
        private readonly IConfiguration? _configuration;

        public MovieContextDb()
        { }

        public MovieContextDb(DbContextOptions options, IConfiguration configuration)
            : base(options)
        {
            base.ChangeTracker.LazyLoadingEnabled = false;
            _configuration = configuration;
        }
        public DbSet<Film> Movie { get; set; }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            var result = await base.SaveChangesAsync(cancellationToken);

            return result;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
