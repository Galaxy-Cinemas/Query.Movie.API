namespace Galaxi.Movie.Domain.DTOs
{
    public class FilmDetailsDTO
    {
        public Guid FilmId { get; set; }
        public string Title { get; set; }
        public string? PosterImage { get; set; }
        public string? Trailer { get; set; }
        public string? Description { get; set; }
        public string? Director { get; set; }
        public string? Genre { get; set; }
        public string? Cast { get; set; }
        public string? Origincountry { get; set; }
        public string? Language { get; set; }
        public string? Classification { get; set; }
        public int? Duration { get; set; }
    }
}
