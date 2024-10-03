using Galaxi.Bus.Message;
using Galaxi.Query.Movie.Persistence.Repositorys;
using MassTransit;

namespace Galaxi.Query.Movie.Domain.IntegrationEvents.Consumers
{
    public class MigrationMovieConsumer : IConsumer<MigrationMovies>
    {
        private readonly IMovieRepository _movieRepo;

        public MigrationMovieConsumer(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public async Task Consume(ConsumeContext<MigrationMovies> context)
        {
            try
            {
                await _movieRepo.MigrateELKAsync(context.Message.Movies);
            }
            catch (Exception ex)
            {

                throw;
            }
               
        }
    }
}
