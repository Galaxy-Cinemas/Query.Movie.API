using Galaxi.Movie.Domain.DTOs;
using MediatR;

namespace Galaxi.Movie.Domain.Infrastructure.Queries
{
    public record GetAllMoviesQuery : IRequest<IEnumerable<FilmSummaryDTO>>;
}
