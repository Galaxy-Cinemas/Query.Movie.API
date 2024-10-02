using Galaxi.Query.Movie.Domain.DTOs;
using MediatR;

namespace Galaxi.Query.Movie.Domain.Infrastructure.Queries
{
    public record GetMovieByIdQuery(Guid filmId) : IRequest<FilmDetailsDTO>;

}
