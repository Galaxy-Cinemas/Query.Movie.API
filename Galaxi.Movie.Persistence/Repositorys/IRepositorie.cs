using Galaxi.Query.Movie.Data.Models;

namespace Galaxi.Query.Movie.Persistence.Repositorys
{
    public interface IRepository
    {
        Task Add(Film movie);
        Task Delete(Film movie);
        Task Update(Film movie);
        Task<bool> SaveAll();
    }
}
