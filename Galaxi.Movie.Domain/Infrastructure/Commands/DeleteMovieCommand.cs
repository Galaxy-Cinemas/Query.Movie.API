using MediatR;

namespace Galaxi.Movie.Domain.Infrastructure.Commands
{
    public record DeleteMovieCommand(Guid FilmId) 
        : IRequest<Unit>;
    
}
