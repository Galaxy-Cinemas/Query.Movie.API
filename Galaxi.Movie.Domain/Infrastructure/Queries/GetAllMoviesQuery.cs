using Galaxi.Query.Movie.Domain.DTOs;
using MediatR;

namespace Galaxi.Query.Movie.Domain.Infrastructure.Queries
{
    public record GetAllMoviesQuery : IRequest<IEnumerable<FilmSummaryDTO>>;
}
