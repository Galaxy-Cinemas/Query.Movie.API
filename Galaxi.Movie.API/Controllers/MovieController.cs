using Galaxi.Query.Movie.Domain.DTOs;
using Galaxi.Query.Movie.Domain.Infrastructure.Queries;
using Galaxi.Query.Movie.Domain.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Galaxi.Query.Movie.API.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<MovieController> _log;

        public MovieController(ILogger<MovieController> log, IMediator mediator)
        {
            _mediator = mediator;
            _log = log;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            try
            {
                _log.LogDebug("RequestStart - [GET] /movies");
                var movies = await _mediator.Send(new GetAllMoviesQuery());
                var successResponse = ResponseHandler<IEnumerable<FilmSummaryDTO>>.SuccessResponse("Movie retrieved successfully", movies);
                _log.LogInformation("Movie retrieved successfully Info");
                return StatusCode(successResponse.StatusCode.Value, successResponse);
            }
            catch (KeyNotFoundException ex)
            {
                _log.LogWarning(ex.Message);
                var response = ResponseHandler<string>.NotFoundResponse("Movies not found.", ex.Message);
                return StatusCode(response.StatusCode.Value, response);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, ex.Message);
                var errorResponse = ResponseHandler<string>.ErrorResponse("An internal server error occurred", ex);
                return StatusCode(errorResponse.StatusCode.Value, errorResponse);
            }
        }

        [HttpGet("{filmId}")]
        public async Task<IActionResult> GetByMovieId(Guid filmId)
        {
            try
            {
                _log.LogDebug($"Processing movie with Id: {filmId}");
                var movie = await _mediator.Send(new GetMovieByIdQuery(filmId));
                var successResponse = ResponseHandler<FilmDetailsDTO>.SuccessResponse("Movie retrieved successfully", movie);
                _log.LogInformation($"Successfully processed GetByMovieId event for MovieId: {movie.FilmId}");
                return StatusCode(successResponse.StatusCode.Value, successResponse);
            }
            catch (InvalidOperationException ex)
            {
                _log.LogWarning(ex.Message);
                var errorResponse = ResponseHandler<string>.ErrorResponse("Failed to save changes to the database.", ex);
                return StatusCode(errorResponse.StatusCode.Value, errorResponse);
            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message);
                var errorResponse = ResponseHandler<string>.ErrorResponse("An internal server error occurred", ex);
                return StatusCode(errorResponse.StatusCode.Value, errorResponse);
            }
        }


        [HttpGet("{query}")]
        public async Task<IActionResult> GetMovieByQuery(string query)
        {
            try
            {
                _log.LogDebug($"Processing movie with Query: {query}");
                var searchMovie = await _mediator.Send(new GetMovieByQueryQuery(query));
                var successResponse = ResponseHandler<IEnumerable<FilmSummaryDTO>>.SuccessResponse("Movies retrieved successfully", searchMovie);
                _log.LogInformation("Movie retrieved successfully Info");
                return StatusCode(successResponse.StatusCode.Value, successResponse);
            }
            catch (InvalidOperationException ex)
            {
                _log.LogWarning(ex.Message);
                var errorResponse = ResponseHandler<string>.ErrorResponse("Failed to save changes to the database.", ex);
                return StatusCode(errorResponse.StatusCode.Value, errorResponse);
            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message);
                var errorResponse = ResponseHandler<string>.ErrorResponse("An internal server error occurred", ex);
                return StatusCode(errorResponse.StatusCode.Value, errorResponse);
            }
        }
    }
}
