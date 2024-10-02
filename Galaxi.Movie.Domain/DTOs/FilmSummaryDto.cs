namespace Galaxi.Query.Movie.Domain.DTOs
{
    public class FilmSummaryDTO
    {
        public Guid FilmId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string PosterImage { get; set; }
        public string? Classification { get; set; }
        public int? Duration { get; set; }
    }
}
