using AutoMapper;
using Galaxi.Query.Movie.Domain.DTOs;
using Galaxi.Query.Movie.Domain.Infrastructure.Queries;
using Galaxi.Query.Movie.Persistence.Repositorys;
using MediatR;

namespace Galaxi.Query.Movie.Domain.Handlers
{
    public class GetMovieByQueryHandler : IRequestHandler<GetMovieByQueryQuery, IEnumerable<FilmSummaryDTO>>
    {
        private readonly IMovieRepository _repo;
        private readonly IMapper _mapper;

        public GetMovieByQueryHandler(IMovieRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FilmSummaryDTO>> Handle(GetMovieByQueryQuery request, CancellationToken cancellationToken)
        {
            var movies = await _repo.GetMovieByQuery(request.query);
            var movieViewModel = _mapper.Map<List<FilmSummaryDTO>>(movies);
            return movieViewModel;
        }
    }
}
