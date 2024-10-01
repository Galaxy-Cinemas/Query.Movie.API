using Galaxi.Movie.Data.Models;

namespace Galaxi.Movie.Persistence.Repositorys
{
    public interface IMovieRepository : IRepository
    {
        Task<IEnumerable<Film>> GetAllMoviesAsync();
        Task<Film> GetMovieByIdAsync(Guid id);
    }
}