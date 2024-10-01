using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Galaxi.Movie.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addtrailerattributte3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("1ff4ce8c-a64f-47f5-a0e9-9e7a61c50142"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("3af90459-cf6e-4464-8a56-f3c27f4762ff"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("42a650be-7030-4b24-bfbe-e509d1e82fc4"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("564c095c-a14c-4305-933d-c5e9318f56e5"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("67974a1f-69ca-4d29-89d8-1a9830e0ef8a"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("76eb56ba-24fe-4908-89ec-9afe54f08a50"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("7ddc1406-7683-4928-b47b-cf19b5747abc"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("8a975566-af83-4484-862a-396bf786c7b9"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("d320518b-24dd-4ad2-a97d-0546b09c6f5d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("d41af0dc-679a-49ce-a4af-17249021396f"));

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Cast", "Description", "Director", "Genre", "Language", "Origincountry", "PosterImage", "Title", "Trailer", "classification", "duration" },
                values: new object[,]
                {
                    { new Guid("02b826f2-8dfb-4c15-ae59-b9176f00e5ad"), "Ivana Baquero, Ariadna Gil, Sergi López", "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", "Guillermo del Toro", "Fantasy", "Spanish", "Spain", "https://i.pinimg.com/564x/0d/e1/d9/0de1d966d8bc5bd1867a7572fa87651f.jpg", "Pan's Labyrinth", "https://www.youtube.com/embed/jVZRnnVSQ8k?si=dCJTObQtyk62LIwd", "B15", 118 },
                    { new Guid("0b5148f0-07d4-4f4b-97b2-a0ea46a40781"), "Rumi Hiiragi, Miyu Irino, Mari Natsuki", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits.", "Hayao Miyazaki", "Animation", "English", "Japan", "https://i.pinimg.com/736x/93/6b/c2/936bc2c8a46385dddd69ecaa1fe1d2d5.jpg", "Spirited Away", "https://www.youtube.com/embed/ByXuk9QqQkk?si=Q1sCfN5g2wRvZPU4", "A", 125 },
                    { new Guid("158671d2-8375-4c41-ab05-2279a91832b6"), "Liam Neeson, Ralph Fiennes, Ben Kingsley", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce.", "Steven Spielberg", "Biography", "English", "USA", "https://i.pinimg.com/564x/58/7a/2a/587a2a1dbb33437d4c48811e020c4ec8.jpg", "Schindler's List", "https://www.youtube.com/embed/mxphAlJID9U?si=14XT-lhGvOhmsl06", "C", 195 },
                    { new Guid("3322382a-b848-4d38-bd1f-7703f30d2f2b"), "Anthony Gonzalez, Gael García Bernal, Benjamin Bratt", "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead.", "Lee Unkrich", "Animation", "English", "USA", "https://i.pinimg.com/564x/7a/6d/c4/7a6dc4222a7bd3037d9f7146314e3bc7.jpg", "Coco", "https://www.youtube.com/embed/awzWdtCezDo?si=UnEw3ZYXDm6Nl2ER", "AA", 105 },
                    { new Guid("444770a0-0bf1-4397-8ef8-436e5fd479ee"), "John Travolta, Uma Thurman, Samuel L. Jackson", "The lives of two mob hitmen, a boxer, and a pair of bandits intertwine in four tales of violence.", "Quentin Tarantino", "Crime", "English", "USA", "https://i.pinimg.com/564x/e4/05/0b/e4050b92335cde4a3b5ae340fc8c5ee3.jpg", "Pulp Fiction", "https://www.youtube.com/embed/tGpTpVyI_OQ?si=cyNza1EHuoMQq8DM", "C", 154 },
                    { new Guid("689e687e-d7e2-4b85-82c7-5a0f67f2803d"), "Song Kang-ho, Lee Sun-kyun, Cho Yeo-jeong", "A poor family schemes to become employed by a wealthy family.", "Bong Joon-ho", "Thriller", "English", "South Korea", "https://i.pinimg.com/564x/a9/7d/26/a97d26449214bb756c75b4ed88d7b06e.jpg", "Parasite", "https://www.youtube.com/embed/5xH0HfJHsaY?si=uqPRQpiUUcnkOmgw", "B15", 132 },
                    { new Guid("89ba1499-f8bb-4e60-91de-cd8a66bed0d8"), "Audrey Tautou, Mathieu Kassovitz, Rufus", "Amélie is an innocent and naive girl in Paris with her own sense of justice.", "Jean-Pierre Jeunet", "Romantic Comedy", "French", "France", "https://i.pinimg.com/564x/d8/9e/ac/d89eac7350c0c7d61b8ca8b22863c398.jpg", "Amélie", "https://www.youtube.com/embed/Py7cDXQae2U?si=1EKFakxcxr0AyumX", "AA", 122 },
                    { new Guid("b10b662a-2ae0-42d5-aae7-5209b6e76e7c"), "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", "A thief who steals corporate secrets through the use of dream-sharing technology.", "Christopher Nolan", "Science Fiction", "English", "USA", "https://i.pinimg.com/564x/43/9a/1c/439a1c4583a953c26b63d08a1d832f53.jpg", "Inception", "https://www.youtube.com/embed/YoHD9XEInc0?si=FOzAaTEzqc0YA6sK", "B", 148 },
                    { new Guid("b5d198e3-be36-4ec9-b3f6-73efd7f3d921"), "Marlon Brando, Al Pacino, James Caan", "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", "Francis Ford Coppola", "Crime", "English", "USA", "https://i.pinimg.com/564x/1d/fa/6c/1dfa6ce2aca118aeddd66249d425c575.jpg", "The Godfather", "https://www.youtube.com/embed/UaVTIH8mujA?si=YCmw9CNpLsz-8jqw", "B15", 175 },
                    { new Guid("cb57f558-fccc-4419-9b30-125903a5a8cd"), "Christian Bale, Heath Ledger, Aaron Eckhart", "Batman begins his fight against crime in Gotham.", "Christopher Nolan", "Action", "English", "USA", "https://i.pinimg.com/564x/ea/a2/6e/eaa26e2c3bfa234c3cdd3c4d9fabad35.jpg", "The Dark Knight", "https://www.youtube.com/embed/EXeTwQWrcwY?si=H-7BhelqVXKIAmTb", "B", 152 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("02b826f2-8dfb-4c15-ae59-b9176f00e5ad"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("0b5148f0-07d4-4f4b-97b2-a0ea46a40781"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("158671d2-8375-4c41-ab05-2279a91832b6"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("3322382a-b848-4d38-bd1f-7703f30d2f2b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("444770a0-0bf1-4397-8ef8-436e5fd479ee"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("689e687e-d7e2-4b85-82c7-5a0f67f2803d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("89ba1499-f8bb-4e60-91de-cd8a66bed0d8"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("b10b662a-2ae0-42d5-aae7-5209b6e76e7c"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("b5d198e3-be36-4ec9-b3f6-73efd7f3d921"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("cb57f558-fccc-4419-9b30-125903a5a8cd"));

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Cast", "Description", "Director", "Genre", "Language", "Origincountry", "PosterImage", "Title", "Trailer", "classification", "duration" },
                values: new object[,]
                {
                    { new Guid("1ff4ce8c-a64f-47f5-a0e9-9e7a61c50142"), "Anthony Gonzalez, Gael García Bernal, Benjamin Bratt", "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead.", "Lee Unkrich", "Animation", "English", "USA", "https://i.pinimg.com/564x/7a/6d/c4/7a6dc4222a7bd3037d9f7146314e3bc7.jpg", "Coco", "https://youtu.be/awzWdtCezDo?si=pTPm98sUcGuNg10o", "AA", 105 },
                    { new Guid("3af90459-cf6e-4464-8a56-f3c27f4762ff"), "Ivana Baquero, Ariadna Gil, Sergi López", "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", "Guillermo del Toro", "Fantasy", "Spanish", "Spain", "https://i.pinimg.com/564x/0d/e1/d9/0de1d966d8bc5bd1867a7572fa87651f.jpg", "Pan's Labyrinth", "https://youtu.be/gpEh4O8Hb5Y?si=yjrHygCStaxnXElN", "B15", 118 },
                    { new Guid("42a650be-7030-4b24-bfbe-e509d1e82fc4"), "Song Kang-ho, Lee Sun-kyun, Cho Yeo-jeong", "A poor family schemes to become employed by a wealthy family.", "Bong Joon-ho", "Thriller", "English", "South Korea", "https://i.pinimg.com/564x/a9/7d/26/a97d26449214bb756c75b4ed88d7b06e.jpg", "Parasite", "https://www.youtube.com/embed/5xH0HfJHsaY?si=uqPRQpiUUcnkOmgw", "B15", 132 },
                    { new Guid("564c095c-a14c-4305-933d-c5e9318f56e5"), "Rumi Hiiragi, Miyu Irino, Mari Natsuki", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits.", "Hayao Miyazaki", "Animation", "English", "Japan", "https://i.pinimg.com/736x/93/6b/c2/936bc2c8a46385dddd69ecaa1fe1d2d5.jpg", "Spirited Away", "https://youtu.be/5Fgq4Osh6XQ?si=R-11rcY5DMGU93bS", "A", 125 },
                    { new Guid("67974a1f-69ca-4d29-89d8-1a9830e0ef8a"), "John Travolta, Uma Thurman, Samuel L. Jackson", "The lives of two mob hitmen, a boxer, and a pair of bandits intertwine in four tales of violence.", "Quentin Tarantino", "Crime", "English", "USA", "https://i.pinimg.com/564x/e4/05/0b/e4050b92335cde4a3b5ae340fc8c5ee3.jpg", "Pulp Fiction", "https://youtu.be/r-PSxjTR174?si=wBYHOne3z1B9THQg", "C", 154 },
                    { new Guid("76eb56ba-24fe-4908-89ec-9afe54f08a50"), "Liam Neeson, Ralph Fiennes, Ben Kingsley", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce.", "Steven Spielberg", "Biography", "English", "USA", "https://i.pinimg.com/564x/58/7a/2a/587a2a1dbb33437d4c48811e020c4ec8.jpg", "Schindler's List", "https://youtu.be/7q-ETFeMxwI?si=A2edRplN3wnRQHgv", "C", 195 },
                    { new Guid("7ddc1406-7683-4928-b47b-cf19b5747abc"), "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", "A thief who steals corporate secrets through the use of dream-sharing technology.", "Christopher Nolan", "Science Fiction", "English", "USA", "https://i.pinimg.com/564x/43/9a/1c/439a1c4583a953c26b63d08a1d832f53.jpg", "Inception", "https://www.youtube.com/embed/YoHD9XEInc0?si=FOzAaTEzqc0YA6sK", "B", 148 },
                    { new Guid("8a975566-af83-4484-862a-396bf786c7b9"), "Marlon Brando, Al Pacino, James Caan", "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", "Francis Ford Coppola", "Crime", "English", "USA", "https://i.pinimg.com/564x/1d/fa/6c/1dfa6ce2aca118aeddd66249d425c575.jpg", "The Godfather", "https://www.youtube.com/embed/UaVTIH8mujA?si=YCmw9CNpLsz-8jqw", "B15", 175 },
                    { new Guid("d320518b-24dd-4ad2-a97d-0546b09c6f5d"), "Audrey Tautou, Mathieu Kassovitz, Rufus", "Amélie is an innocent and naive girl in Paris with her own sense of justice.", "Jean-Pierre Jeunet", "Romantic Comedy", "French", "France", "https://i.pinimg.com/564x/d8/9e/ac/d89eac7350c0c7d61b8ca8b22863c398.jpg", "Amélie", "https://www.youtube.com/embed/Py7cDXQae2U?si=1EKFakxcxr0AyumX", "AA", 122 },
                    { new Guid("d41af0dc-679a-49ce-a4af-17249021396f"), "Christian Bale, Heath Ledger, Aaron Eckhart", "Batman begins his fight against crime in Gotham.", "Christopher Nolan", "Action", "English", "USA", "https://i.pinimg.com/564x/ea/a2/6e/eaa26e2c3bfa234c3cdd3c4d9fabad35.jpg", "The Dark Knight", "https://youtu.be/dzQtWkpc2-c?si=7lXCPkDAji-Eu3V7", "B", 152 }
                });
        }
    }
}
