using Galaxi.Movie.Data.Models;
using Galaxi.Movie.Persistence.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace Galaxi.Movie.Persistence.Repositorys
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContextDb _context;
        private readonly IDistributedCache _cache;
        private readonly ILogger<MovieRepository> _log;
        private readonly TimeSpan _cacheExpiration = TimeSpan.FromMinutes(10);
        private const string _cacheKeyAllMovies = "movies_all";

        public MovieRepository(MovieContextDb context, IDistributedCache cache, ILogger<MovieRepository> log)
        {
            _context = context;
            _cache = cache;
            _log = log;
        }

        public async Task Add(Film movie)
        {
            _context.Add(movie);
            await RemoveCacheAsync(movie.FilmId);
        }

        public async Task Delete(Film movie)
        {
            _context.Movie.Remove(movie);
            await RemoveCacheAsync(movie.FilmId);
        }

        public async Task Update(Film movie)
        {
            _context.Update(movie);
            await RemoveCacheAsync(movie.FilmId);
        }

        public async Task<Film> GetMovieByIdAsync(Guid id)
        {
            var cacheKey = $"movie_{id}";

            var cacheMovie = await GetCacheAsync<Film>(cacheKey);

            if (cacheMovie != null)
            {
                return cacheMovie;
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(u => u.FilmId == id);

            if (movie != null)
            {
                _ = SetCacheAsync(movie, cacheKey);
            }
            return movie;
        }

        public async Task<IEnumerable<Film>> GetAllMoviesAsync()
        {
            var cacheMovies = await GetCacheAsync<IEnumerable<Film>>(_cacheKeyAllMovies);

            if (cacheMovies != null)
            {
                return cacheMovies;
            }

            var movies = await _context.Movie.ToListAsync();

            if (movies != null && movies.Any())
            {
                _ = SetCacheAsync(movies, _cacheKeyAllMovies);
            }

            return movies;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }


        private async Task SetCacheAsync<T>(T entity, string cacheKey)
        {
            try
            {
                await _cache.SetStringAsync
                             (cacheKey, JsonConvert.SerializeObject(entity),
                               new DistributedCacheEntryOptions
                               {
                                   AbsoluteExpirationRelativeToNow = _cacheExpiration
                               }
                             );
            }
            catch (Exception ex)
            {
                _log.LogWarning("Failed to set cache in Redis", ex);
            }

        }

        private async Task<T> GetCacheAsync<T>(string cacheKey) where T : class
        {
            try
            {
                var cachedData = await _cache.GetStringAsync(cacheKey);
                if (!string.IsNullOrEmpty(cachedData))
                {
                    return JsonConvert.DeserializeObject<T>(cachedData);
                }
            }
            catch (RedisException ex)
            {
                _log.LogWarning($"Failed to retrieve cache in Redis for key {cacheKey}", ex);
            }
            catch (Exception ex)
            {
                _log.LogWarning($"An unexpected error occurred when retrieving cache for key {cacheKey}", ex);
            }
            return null;
        }

        private async Task RemoveCacheAsync(Guid filmId)
        {
            try
            {
                await Task.WhenAll(
                        _cache.RemoveAsync($"movie_{filmId}"),
                        _cache.RemoveAsync(_cacheKeyAllMovies)
                    );
            }
            catch (RedisException ex)
            {
                _log.LogWarning($"Failed to remove cache in Redis for movie {filmId}", ex);
            }
            catch (Exception ex)
            {
                _log.LogWarning($"An unexpected error occurred when removing cache for movie {filmId}", ex);
            }
        }

        public async Task MigrateAsync()
        {
            await _context.Database.MigrateAsync();
        }

    }
}
