using AutoMapper;
using Galaxi.Movie.Data.Models;
using Galaxi.Movie.Domain.DTOs;
using Galaxi.Movie.Domain.Infrastructure.Commands;

namespace Galaxi.Movie.Domain.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Film, FilmDetailsDTO>();
            CreateMap<Film, FilmSummaryDTO>();
            CreateMap<Film, CreatedFilmReponseDTO>();

            CreateMap<CreatedMovieCommand, Film>();
            CreateMap<UpdateMovieCommand, Film>();
        }
    }
}
