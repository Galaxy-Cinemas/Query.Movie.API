using Galaxi.Query.Movie.Domain.DTOs;
using Galaxi.Query.Movie.Domain.Infrastructure.Queries;
using Galaxi.Query.Movie.Domain.Response;
using Galaxi.Query.Movie.Persistence.Repositorys;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Galaxi.Query.Movie.API.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMovieRepository _repo;
        private readonly ILogger<MovieController> _log;

        public MovieController(IMovieRepository repo, ILogger<MovieController> log, IMediator mediator)
        {
            _mediator = mediator;
            _repo = repo;
            _log = log;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            try
            {
                _log.LogDebug("RequestStart - [GET] /movies");
                var movies = await _mediator.Send(new GetAllMoviesQuery());
                var successResponse = ResponseHandler<IEnumerable<FilmSummaryDTO>>.CreateSuccessResponse("Movie retrieved successfully", movies);
                _log.LogInformation("Movie retrieved successfully Info");
                return StatusCode(successResponse.StatusCode.Value, successResponse);
            }
            catch (KeyNotFoundException ex)
            {
                _log.LogWarning(ex.Message);
                var response = ResponseHandler<string>.CreateNotFoundResponse("Movies not found.", ex.Message);
                return StatusCode(response.StatusCode.Value, response);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, ex.Message);
                var errorResponse = ResponseHandler<string>.CreateErrorResponse("An internal server error occurred", ex);
                return StatusCode(errorResponse.StatusCode.Value, errorResponse);
            }
        }

        [HttpGet("{filmId}")]
        public async Task<IActionResult> GetByMovieId(Guid filmId)
        {
            try
            {
                _log.LogDebug("Processing movie with Id: {filmId}", filmId);
                var movie = await _mediator.Send(new GetMovieByIdQuery(filmId));
                var successResponse = ResponseHandler<FilmDetailsDTO>.CreateSuccessResponse("Movie retrieved successfully", movie);
                _log.LogInformation($"Successfully processed GetByMovieId event for MovieId: {movie.FilmId}");
                return StatusCode(successResponse.StatusCode.Value, successResponse);
            }
            catch (InvalidOperationException ex)
            {
                _log.LogWarning(ex.Message);
                var errorResponse = ResponseHandler<string>.CreateErrorResponse("Failed to save changes to the database.", ex);
                return StatusCode(errorResponse.StatusCode.Value, errorResponse);
            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message);
                var errorResponse = ResponseHandler<string>.CreateErrorResponse("An internal server error occurred", ex);
                return StatusCode(errorResponse.StatusCode.Value, errorResponse);
            }
        }
    }
}
