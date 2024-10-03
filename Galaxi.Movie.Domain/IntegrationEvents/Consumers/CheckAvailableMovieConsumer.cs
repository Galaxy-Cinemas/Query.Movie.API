using Galaxi.Bus.Message;
using Galaxi.Query.Movie.Data.Models;
using Galaxi.Query.Movie.Persistence.Repositorys;
using MassTransit;

namespace Galaxi.Query.Movie.Domain.IntegrationEvents.Consumers
{
    public class CheckAvailableMovieConsumer : IConsumer<CheckAvailableMovie>
    {
        private readonly IMovieRepository _movieRepo;

        public CheckAvailableMovieConsumer(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public async Task Consume(ConsumeContext<CheckAvailableMovie> context)
        {
            Film movie = await _movieRepo.GetMovieByIdAsync(context.Message.MovieId);

            var exist = movie != null;

            await context.RespondAsync(new MovieStatus
            {
                Exist = exist
            });

        }
    }
}
