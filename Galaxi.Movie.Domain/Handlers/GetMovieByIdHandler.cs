using AutoMapper;
using Galaxi.Movie.Data.Models;
using Galaxi.Movie.Domain.DTOs;
using Galaxi.Movie.Domain.Infrastructure.Queries;
using Galaxi.Movie.Persistence.Repositorys;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Galaxi.Movie.Domain.Handlers
{
    public class GetMovieByIdHandler
         : IRequestHandler<GetMovieByIdQuery, FilmDetailsDTO>
    {
        private readonly IMovieRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<GetMovieByIdHandler> _log;
        public GetMovieByIdHandler(IMovieRepository repo, IMapper mapper, ILogger<GetMovieByIdHandler> log)
        {
            _repo = repo;
            _mapper = mapper;
            _log = log;
        }

        public async Task<FilmDetailsDTO> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {

            Film movieById = await _repo.GetMovieByIdAsync(request.filmId);
            if (movieById == null)
            {
                throw new KeyNotFoundException();
            }
            var movieByIdViewModel = _mapper.Map<FilmDetailsDTO>(movieById);
            return movieByIdViewModel;
        }
    }
}
