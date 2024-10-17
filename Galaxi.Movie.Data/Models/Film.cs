namespace Galaxi.Query.Movie.Data.Models
{
    public class Film
    {
        public Guid FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? PosterImage { get; set; }
        public string? Trailer { get; set; }
        public string? Director { get; set; }
        public string? Genre { get; set; }
        public string? Cast { get; set; }
        public string? Origincountry { get; set; }
        public Language? Language { get; set; }
        public classification? classification { get; set; }
        public int? duration { get; set; }

    }

    public enum Language
    {
        English,
        Spanish,
        French
    }

    public enum classification
    {
        AA,
        A,
        B,
        B15,
        C
    }

}
