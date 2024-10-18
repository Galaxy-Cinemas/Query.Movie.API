using Galaxi.Query.Movie.Domain.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxi.Query.Movie.Domain.Infrastructure.Queries
{
    public record GetMovieByQueryQuery(string query) : IRequest<IEnumerable<FilmSummaryDTO>>;
}
