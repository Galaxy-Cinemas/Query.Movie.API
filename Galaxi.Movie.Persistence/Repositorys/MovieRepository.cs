using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using Galaxi.Query.Movie.Data.Models;
using Elastic.Clients.Elasticsearch;
using Elastic.Clients.Elasticsearch.QueryDsl;

namespace Galaxi.Query.Movie.Persistence.Repositorys
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IDistributedCache _cache;
        private readonly ILogger<MovieRepository> _log;
        private readonly ElasticsearchClient _elasticsearch;
        private readonly TimeSpan _cacheExpiration = TimeSpan.FromMinutes(10);
        private const string _cacheKeyAllMovies = "movies_all";

        public MovieRepository(IDistributedCache cache, ILogger<MovieRepository> log, ElasticsearchClient elasticsearch)
        {
            _cache = cache;
            _log = log;
            _elasticsearch = elasticsearch;
        }

        public async Task Add(Film movie)
        {
            _log.LogInformation($"Creating new movie with ID (elasticSearch) {movie.FilmId}");
            var addMovie = await _elasticsearch.IndexAsync<Film>(movie, idx => idx.Index("films"));

            await RemoveCacheAsync(movie.FilmId);
        }

        public async Task Delete(Film movie)
        {
            _log.LogInformation($"Delete movie with movieId (elasticSearch) {movie.FilmId}");

            var searchResponse = await _elasticsearch.SearchAsync<Film>(s => s
               .Index("films")
               .Query(q => q
                   .Term(t => t
                       .Field(f => f.FilmId)
                       .Value(movie.FilmId.ToString())
                   )
               )
           );

            var hit = searchResponse.Hits.FirstOrDefault();

            var deleteResponse = await _elasticsearch.DeleteAsync<Film>(hit.Id, u => u
                .Index("films")
            );

            await RemoveCacheAsync(movie.FilmId);
        }

        public async Task UpdateMovieAsync(Film movie)
        {
            _log.LogInformation($"Updating movie with movie ID (elasticSearch) {movie.FilmId}");


            var searchResponse = await GetIdDocElasticByMovieId(movie.FilmId);

            var updateResponse = await _elasticsearch.UpdateAsync<ElasticsearchClient, Film>(searchResponse, u => u
                .Index("films")
                .Doc(movie)
            );

            await RemoveCacheAsync(movie.FilmId);
        }

        protected async Task<string> GetIdDocElasticByMovieId(Guid FilmId)
        {
            var searchResponse = await _elasticsearch.SearchAsync<Film>(s => s
               .Index("films")
               .Query(q => q
                   .Term(t => t
                       .Field(f => f.FilmId)
                       .Value(FilmId.ToString())
                   )
               )
           );

            var hit = searchResponse.Hits.FirstOrDefault();

            return hit.Id;

        }

        public async Task<Film> GetMovieByIdAsync(Guid id)
        {
            var cacheKey = $"movie_{id}";

            var cacheMovie = await GetCacheAsync<Film>(cacheKey);

            if (cacheMovie != null)
            {
                return cacheMovie;
            }

            var movie = await _elasticsearch.SearchAsync<Film>(s => s
                           .Index("films")
                           .Query(q => q
                               .Term(t => t
                                   .Field(f => f.FilmId)
                                   .Value(id.ToString())
                               )
                           )
                       );

            if (movie.Documents.FirstOrDefault() != null)
            {
                _ = SetCacheAsync(movie.Documents.FirstOrDefault(), cacheKey);
            }
            return movie.Documents.FirstOrDefault();
        }

        public async Task<IEnumerable<Film>> GetAllMoviesAsync()
        {
            var cacheMovies = await GetCacheAsync<IEnumerable<Film>>(_cacheKeyAllMovies);

            if (cacheMovies != null)
            {
                return cacheMovies;
            }

            var movies = await _elasticsearch.SearchAsync<Film>(s => s
                                .Index("films")
                                .Query(q => q.MatchAll(Ma => Ma = Ma))
                                .Size(1000)
                            );

            if (movies != null && movies.Documents.Any())
            {
                _ = SetCacheAsync(movies.Documents, _cacheKeyAllMovies);
            }

            return movies.Documents;
        }

        public async Task<IEnumerable<Film>> GetMovieByQuery(string query)
        {
            string cacheQueryKey = $"Movie_query_{query}";

            var cacheMovies = await GetCacheAsync<IEnumerable<Film>>(cacheQueryKey);

            if (cacheMovies != null)
            {
                return cacheMovies;
            }

            var searchMovieResponse = await _elasticsearch.SearchAsync<Film>(s => s
                    .Query(q => q
                        .SimpleQueryString(sqs => sqs
                            .Query($"*{query}*")
                            .Fields(new[] { "title^3", "genre^2", "description^1" })
                            .DefaultOperator(Operator.And)
                            .AnalyzeWildcard(true)
                        )
                    )
                );

            if (searchMovieResponse != null && searchMovieResponse.Documents.Any())
            {
                _ = SetCacheAsync(searchMovieResponse.Documents, cacheQueryKey);
            }

            return searchMovieResponse.Documents;
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

        public async Task MigrateELKAsync(IEnumerable<Film> films)
        {
            try
            {
                await _elasticsearch.Indices.CreateAsync<Film>("films", c => c
                     .Mappings(m => m
                         .Properties(p => p
                             .Keyword(k => k
                                 .FilmId
                                 ))
              ));
            }
            catch (Exception)
            {
                _log.LogWarning($"Failed to create index to the ElasticSearch");
            }

            _log.LogInformation($"Creating {films.Count()} films in bulk");

            foreach (var film in films)
            {
                if (film.FilmId == Guid.Empty)
                {
                    film.FilmId = Guid.NewGuid();
                }
            }

            try
            {
                var bulkResponse = await _elasticsearch.BulkAsync(b => b
                           .Index("films")
                           .IndexMany(films, (descriptor, film) => descriptor
                               .Index("films")
                               .Id(film.FilmId.ToString())
                           )
                       );
            }
            catch (Exception)
            {
                _log.LogError($"Failed to insert documents into elasticSearch");
            }

            _log.LogInformation($"{films.Count()} movies were created successfully");
        }
    }
}
