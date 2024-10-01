using Galaxi.Movie.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Galaxi.Movie.Persistence.Configurations
{
    public class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.ToTable("Films");

            builder.HasKey(f => f.FilmId);

            builder.Property(f => f.FilmId)
                .ValueGeneratedOnAdd();

            builder.Property(f => f.Title)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(f => f.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(f => f.PosterImage)
                .HasMaxLength(255);

            builder.Property(f => f.Director)
                .HasMaxLength(100);

            builder.Property(f => f.Genre)
                .HasMaxLength(100);

            builder.Property(f => f.Cast)
                .HasMaxLength(500);

            builder.Property(f => f.Origincountry)
                .HasMaxLength(100);

            builder.Property(f => f.Language)
                .HasConversion(
                    l => l.ToString(),
                    l => (Language)Enum.Parse(typeof(Language), l))
                .IsRequired();

            builder.Property(f => f.classification)
                .HasConversion(
                    c => c.ToString(),
                    c => (classification)Enum.Parse(typeof(classification), c))
                .IsRequired();

            #region HasData

            builder.HasData(
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "Inception",
                   Description = "A thief who steals corporate secrets through the use of dream-sharing technology.",
                   PosterImage = "https://i.pinimg.com/564x/43/9a/1c/439a1c4583a953c26b63d08a1d832f53.jpg",
                   Trailer = "https://www.youtube.com/embed/YoHD9XEInc0?si=FOzAaTEzqc0YA6sK",
                   Director = "Christopher Nolan",
                   Genre = "Science Fiction",
                   Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page",
                   Origincountry = "USA",
                   Language = Language.English,
                   classification = classification.B,
                   duration = 148
               },
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "Parasite",
                   Description = "A poor family schemes to become employed by a wealthy family.",
                   PosterImage = "https://i.pinimg.com/564x/a9/7d/26/a97d26449214bb756c75b4ed88d7b06e.jpg",
                   Trailer = "https://www.youtube.com/embed/5xH0HfJHsaY?si=uqPRQpiUUcnkOmgw",
                   Director = "Bong Joon-ho",
                   Genre = "Thriller",
                   Cast = "Song Kang-ho, Lee Sun-kyun, Cho Yeo-jeong",
                   Origincountry = "South Korea",
                   Language = Language.English,
                   classification = classification.B15,
                   duration = 132
               },
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "The Godfather",
                   Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.",
                   PosterImage = "https://i.pinimg.com/564x/1d/fa/6c/1dfa6ce2aca118aeddd66249d425c575.jpg",
                   Trailer = "https://www.youtube.com/embed/UaVTIH8mujA?si=YCmw9CNpLsz-8jqw",
                   Director = "Francis Ford Coppola",
                   Genre = "Crime",
                   Cast = "Marlon Brando, Al Pacino, James Caan",
                   Origincountry = "USA",
                   Language = Language.English,
                   classification = classification.B15,
                   duration = 175
               },
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "Amélie",
                   Description = "Amélie is an innocent and naive girl in Paris with her own sense of justice.",
                   PosterImage = "https://i.pinimg.com/564x/d8/9e/ac/d89eac7350c0c7d61b8ca8b22863c398.jpg",
                   Trailer = "https://www.youtube.com/embed/Py7cDXQae2U?si=1EKFakxcxr0AyumX",
                   Director = "Jean-Pierre Jeunet",
                   Genre = "Romantic Comedy",
                   Cast = "Audrey Tautou, Mathieu Kassovitz, Rufus",
                   Origincountry = "France",
                   Language = Language.French,
                   classification = classification.AA,
                   duration = 122
               },
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "Pulp Fiction",
                   Description = "The lives of two mob hitmen, a boxer, and a pair of bandits intertwine in four tales of violence.",
                   PosterImage = "https://i.pinimg.com/564x/e4/05/0b/e4050b92335cde4a3b5ae340fc8c5ee3.jpg",
                   Trailer = "https://www.youtube.com/embed/tGpTpVyI_OQ?si=cyNza1EHuoMQq8DM",
                   Director = "Quentin Tarantino",
                   Genre = "Crime",
                   Cast = "John Travolta, Uma Thurman, Samuel L. Jackson",
                   Origincountry = "USA",
                   Language = Language.English,
                   classification = classification.C,
                   duration = 154
               },
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "Coco",
                   Description = "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead.",
                   PosterImage = "https://i.pinimg.com/564x/7a/6d/c4/7a6dc4222a7bd3037d9f7146314e3bc7.jpg",
                   Trailer = "https://www.youtube.com/embed/awzWdtCezDo?si=UnEw3ZYXDm6Nl2ER",
                   Director = "Lee Unkrich",
                   Genre = "Animation",
                   Cast = "Anthony Gonzalez, Gael García Bernal, Benjamin Bratt",
                   Origincountry = "USA",
                   Language = Language.English,
                   classification = classification.AA,
                   duration = 105
               },
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "The Dark Knight",
                   Description = "Batman begins his fight against crime in Gotham.",
                   PosterImage = "https://i.pinimg.com/564x/ea/a2/6e/eaa26e2c3bfa234c3cdd3c4d9fabad35.jpg",
                   Trailer = "https://www.youtube.com/embed/EXeTwQWrcwY?si=H-7BhelqVXKIAmTb",
                   Director = "Christopher Nolan",
                   Genre = "Action",
                   Cast = "Christian Bale, Heath Ledger, Aaron Eckhart",
                   Origincountry = "USA",
                   Language = Language.English,
                   classification = classification.B,
                   duration = 152
               },
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "Spirited Away",
                   Description = "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits.",
                   PosterImage = "https://i.pinimg.com/736x/93/6b/c2/936bc2c8a46385dddd69ecaa1fe1d2d5.jpg",
                   Trailer = "https://www.youtube.com/embed/ByXuk9QqQkk?si=Q1sCfN5g2wRvZPU4",
                   Director = "Hayao Miyazaki",
                   Genre = "Animation",
                   Cast = "Rumi Hiiragi, Miyu Irino, Mari Natsuki",
                   Origincountry = "Japan",
                   Language = Language.English,
                   classification = classification.A,
                   duration = 125
               },
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "Pan's Labyrinth",
                   Description = "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.",
                   PosterImage = "https://i.pinimg.com/564x/0d/e1/d9/0de1d966d8bc5bd1867a7572fa87651f.jpg",
                   Trailer = "https://www.youtube.com/embed/jVZRnnVSQ8k?si=dCJTObQtyk62LIwd",
                   Director = "Guillermo del Toro",
                   Genre = "Fantasy",
                   Cast = "Ivana Baquero, Ariadna Gil, Sergi López",
                   Origincountry = "Spain",
                   Language = Language.Spanish,
                   classification = classification.B15,
                   duration = 118
               },
               new Film
               {
                   FilmId = Guid.NewGuid(),
                   Title = "Schindler's List",
                   Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce.",
                   PosterImage = "https://i.pinimg.com/564x/58/7a/2a/587a2a1dbb33437d4c48811e020c4ec8.jpg",
                   Trailer = "https://www.youtube.com/embed/mxphAlJID9U?si=14XT-lhGvOhmsl06",
                   Director = "Steven Spielberg",
                   Genre = "Biography",
                   Cast = "Liam Neeson, Ralph Fiennes, Ben Kingsley",
                   Origincountry = "USA",
                   Language = Language.English,
                   classification = classification.C,
                   duration = 195
               }
           );

            #endregion

        }
    }
}
