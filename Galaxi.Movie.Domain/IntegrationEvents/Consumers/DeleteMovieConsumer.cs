using Galaxi.Bus.Message;
using Galaxi.Query.Movie.Persistence.Repositorys;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxi.Query.Movie.Domain.IntegrationEvents.Consumers
{
    public class DeleteMovieConsumer : IConsumer<DeleteMovie>
    {
        private readonly IMovieRepository _movieRepo;

        public DeleteMovieConsumer(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public async Task Consume(ConsumeContext<DeleteMovie> context)
        {
            await _movieRepo.Delete(context.Message.film);
        }
    }
}
