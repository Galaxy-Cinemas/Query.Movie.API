using Galaxi.Bus.Message;
using Galaxi.Query.Movie.Persistence.Repositorys;
using MassTransit;

namespace Galaxi.Query.Movie.Domain.IntegrationEvents.Consumers
{
    public class UpdateMovieConsumer : IConsumer<UpdateMovie>
    {
        private readonly IMovieRepository _movieRepo;

        public UpdateMovieConsumer(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public async Task Consume(ConsumeContext<UpdateMovie> context)
        {
            await _movieRepo.UpdateMovieAsync(context.Message.film);
        }
    }
}
