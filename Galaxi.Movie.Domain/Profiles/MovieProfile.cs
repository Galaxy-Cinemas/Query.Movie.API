using AutoMapper;
using Galaxi.Query.Movie.Data.Models;
using Galaxi.Query.Movie.Domain.DTOs;

namespace Galaxi.Query.Movie.Domain.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Film, FilmDetailsDTO>();
            CreateMap<Film, FilmSummaryDTO>();
        }
    }
}
