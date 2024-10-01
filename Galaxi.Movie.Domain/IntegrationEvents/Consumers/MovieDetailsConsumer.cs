using Galaxi.Bus.Message;
using Galaxi.Movie.Persistence.Persistence;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace Galaxi.Movie.Domain.IntegrationEvents.Consumers
{
    public class MovieDetailsConsumer : IConsumer<TickedCreated>
    {
        private readonly MovieContextDb _contextDb;
        private readonly ILogger<MovieDetailsConsumer> _log;
        public MovieDetailsConsumer(ILogger<MovieDetailsConsumer> log,MovieContextDb contextDb)
        {
            _contextDb = contextDb;
            _log = log;
        }

        public async Task Consume(ConsumeContext<TickedCreated> context)
        {
            _log.LogInformation(" --- new event return movie details for Email");
            try
            {
                _log.LogInformation(" --- Function Id: {0}", context.Message.FunctionId);
                //Film MovieDetails = await _contextDb.Movie.FirstOrDefaultAsync(x => x.  context.Message.FunctionId);

            }
            catch (Exception ex)
            {

                throw;
            }

            throw new NotImplementedException();
        }
    }
}
