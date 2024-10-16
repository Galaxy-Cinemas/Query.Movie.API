using Galaxi.Query.Movie.Data.Models;

namespace Galaxi.Bus.Message
{
    public record TickedCreated
    {
        public int FunctionId { get; init; }
        public int NumSeat { get; init; }
        public string Email { get; init; }
    }
    public record MovieDetails
    {
        public int FunctionId { get; init; }
        public int NumSeat { get; init; }
        public string Email { get; init; }
    }

    public record CheckAvailableMovie
    {
        public Guid MovieId { get; init; }
    }

    public record MovieStatus
    {
        public bool Exist { get; init; }
    }

    public record MigrationMovies
    {
        public IEnumerable<Film> Movies { get; init; }
    }

    public record UpdateMovie
    {
        public Film film { get; init; }
    }
    public record AddMovie
    {
        public Film film { get; init; }
    }

    public record DeleteMovie
    {
        public Film film { get; init; }
    }
}
