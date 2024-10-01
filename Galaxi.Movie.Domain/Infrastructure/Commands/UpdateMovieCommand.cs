using Galaxi.Movie.Data.Models;
using MediatR;

namespace Galaxi.Movie.Domain.Infrastructure.Commands
{
    public record UpdateMovieCommand 
        (
             Guid FilmId,
             string Title,
             string Description,
             string PosterImage,
             string Director,
             string Genre,
             string Cast,
             string Origincountry,
             Language Language,
             classification classification,
             int duration
        )
        : IRequest<Unit>;
}
