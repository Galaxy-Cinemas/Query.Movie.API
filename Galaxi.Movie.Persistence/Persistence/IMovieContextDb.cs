using Galaxi.Query.Movie.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Galaxi.Movie.Persistence.Persistence
{
    public interface IMovieContextDb
    {
        DbSet<Film> Movie { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}