using Galaxi.Movie.Data.Models;
using Galaxi.Movie.Domain.DTOs;
using MediatR;

namespace Galaxi.Movie.Domain.Infrastructure.Commands
{
    public record CreatedMovieCommand
        (
             string Title,
             string? Description,
             string? PosterImage,
             string? Director,
             string? Genre,
             string? Cast,
             string? Origincountry,
             Language Language,
             classification classification,
             int? duration
        )
        : IRequest<CreatedFilmReponseDTO>;
}
