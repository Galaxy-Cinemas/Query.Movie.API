using Galaxi.Movie.Domain.DTOs;
using MediatR;

namespace Galaxi.Movie.Domain.Infrastructure.Queries
{
    public record GetMovieByIdQuery(Guid filmId) : IRequest<FilmDetailsDTO>;
    
}
