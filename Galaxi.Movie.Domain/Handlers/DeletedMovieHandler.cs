using Galaxi.Movie.Domain.Infrastructure.Commands;
using Galaxi.Movie.Persistence.Repositorys;
using MediatR;

namespace Galaxi.Movie.Domain.Handlers
{
    public class DeletedMovieHandler
        : IRequestHandler<DeleteMovieCommand, Unit>
    {
        private readonly IMovieRepository _repo;

        public DeletedMovieHandler(IMovieRepository repo)
        {
            _repo = repo;
        }
        public async Task<Unit> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            var existingMovie = await _repo.GetMovieByIdAsync(request.FilmId);
            if (existingMovie == null)
            {
                throw new KeyNotFoundException();   
            }

            await _repo.Delete(existingMovie);
            var sucess = await _repo.SaveAll();

            if (!sucess)
            {
                throw new InvalidOperationException();
            }

            return Unit.Value;
        }
    }
}
