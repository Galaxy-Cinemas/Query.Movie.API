using AutoMapper;
using Galaxi.Query.Movie.Domain.DTOs;
using Galaxi.Query.Movie.Domain.Infrastructure.Queries;
using Galaxi.Query.Movie.Persistence.Repositorys;
using MediatR;

namespace Galaxi.Query.Movie.Domain.Handlers
{
    public class GetAllMoviesHandler : IRequestHandler<GetAllMoviesQuery, IEnumerable<FilmSummaryDTO>>
    {
        private readonly IMovieRepository _repo;
        private readonly IMapper _mapper;

        public GetAllMoviesHandler(IMovieRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FilmSummaryDTO>> Handle(GetAllMoviesQuery request, CancellationToken cancellationToken)
        {
            var movies = await _repo.GetAllMoviesAsync();
            if (movies == null || !movies.Any())
            {
                throw new KeyNotFoundException();
            }

            var movieViewModel = _mapper.Map<List<FilmSummaryDTO>>(movies);

            return movieViewModel;
        }
    }
}
