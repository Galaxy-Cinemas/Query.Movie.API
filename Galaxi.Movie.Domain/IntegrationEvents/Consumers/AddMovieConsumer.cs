using Galaxi.Bus.Message;
using Galaxi.Query.Movie.Persistence.Repositorys;
using MassTransit;

namespace Galaxi.Query.Movie.Domain.IntegrationEvents.Consumers
{
    public class AddMovieConsumer : IConsumer<AddMovie>
    {
        private readonly IMovieRepository _movieRepo;

        public AddMovieConsumer(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public async Task Consume(ConsumeContext<AddMovie> context)
        {
            await _movieRepo.Add(context.Message.film);
        }
    }
}
