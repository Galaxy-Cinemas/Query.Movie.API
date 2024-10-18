using Galaxi.Query.Movie.Data.Models;

namespace Galaxi.Query.Movie.Persistence.Repositorys
{
    public interface IMovieRepository : IRepository
    {
        Task<IEnumerable<Film>> GetAllMoviesAsync();
        Task<Film> GetMovieByIdAsync(Guid id);
        Task<IEnumerable<Film>> GetMovieByQuery(string query);
        Task MigrateELKAsync(IEnumerable<Film> films);
    }
}