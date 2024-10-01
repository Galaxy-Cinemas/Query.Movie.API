using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Galaxi.Movie.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addtrailerattributte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("0020a7da-22cb-44ac-ae4a-b46747683ef4"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("22c49b34-d7ae-477e-9685-4a77f58de2e8"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("2a062749-99de-4390-a140-1feafcc682dc"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("2c019fb3-bf0d-41b8-8d68-15e3e8c0d97d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("38a77cb7-1188-4030-bba3-07c8e2157d1b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("46d71754-8612-4e53-bda5-aad242ca633a"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("a5f837cd-e598-44eb-bbe0-d87c9494ac5c"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("bd3e052f-fc64-4004-8c06-53cb256eb1f9"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("be645d21-cd92-444c-9b6b-d1757dc6ad18"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("ff464041-d0fd-4b06-9616-34e08071d5e3"));

            migrationBuilder.AddColumn<string>(
                name: "Trailer",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Cast", "Description", "Director", "Genre", "Language", "Origincountry", "PosterImage", "Title", "Trailer", "classification", "duration" },
                values: new object[,]
                {
                    { new Guid("02070507-b97f-49e5-9e17-e3517bce8745"), "Song Kang-ho, Lee Sun-kyun, Cho Yeo-jeong", "A poor family schemes to become employed by a wealthy family.", "Bong Joon-ho", "Thriller", "English", "South Korea", "https://i.pinimg.com/564x/a9/7d/26/a97d26449214bb756c75b4ed88d7b06e.jpg", "Parasite", "https://youtu.be/5xH0HfJHsaY?si=rHhP6Tybaauy1ep5", "B15", 132 },
                    { new Guid("0c7fbe2b-f20d-4c23-8b8d-7b6580a21d34"), "Rumi Hiiragi, Miyu Irino, Mari Natsuki", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits.", "Hayao Miyazaki", "Animation", "English", "Japan", "https://i.pinimg.com/736x/93/6b/c2/936bc2c8a46385dddd69ecaa1fe1d2d5.jpg", "Spirited Away", "https://youtu.be/5Fgq4Osh6XQ?si=R-11rcY5DMGU93bS", "A", 125 },
                    { new Guid("1f5a7d87-ed57-4513-b83e-9190113c9407"), "Audrey Tautou, Mathieu Kassovitz, Rufus", "Amélie is an innocent and naive girl in Paris with her own sense of justice.", "Jean-Pierre Jeunet", "Romantic Comedy", "French", "France", "https://i.pinimg.com/564x/d8/9e/ac/d89eac7350c0c7d61b8ca8b22863c398.jpg", "Amélie", "https://youtu.be/tHVO-i3KWGg?si=9vwiKfAUVtXyqAsA", "AA", 122 },
                    { new Guid("32d9080d-51a5-48d3-912c-5fa0e363f854"), "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", "A thief who steals corporate secrets through the use of dream-sharing technology.", "Christopher Nolan", "Science Fiction", "English", "USA", "https://i.pinimg.com/564x/43/9a/1c/439a1c4583a953c26b63d08a1d832f53.jpg", "Inception", "https://youtu.be/8hP9D6kZseM?si=CsA2PPoJ5C7FMdis", "B", 148 },
                    { new Guid("7a84ec21-b6a6-4fb7-84e9-411a4a41fc6d"), "John Travolta, Uma Thurman, Samuel L. Jackson", "The lives of two mob hitmen, a boxer, and a pair of bandits intertwine in four tales of violence.", "Quentin Tarantino", "Crime", "English", "USA", "https://i.pinimg.com/564x/e4/05/0b/e4050b92335cde4a3b5ae340fc8c5ee3.jpg", "Pulp Fiction", "https://youtu.be/r-PSxjTR174?si=wBYHOne3z1B9THQg", "C", 154 },
                    { new Guid("93128e3d-c28d-4be8-8f2c-d87145c3f3b1"), "Christian Bale, Heath Ledger, Aaron Eckhart", "Batman begins his fight against crime in Gotham.", "Christopher Nolan", "Action", "English", "USA", "https://i.pinimg.com/564x/ea/a2/6e/eaa26e2c3bfa234c3cdd3c4d9fabad35.jpg", "The Dark Knight", "https://youtu.be/dzQtWkpc2-c?si=7lXCPkDAji-Eu3V7", "B", 152 },
                    { new Guid("a2fc8ed0-cbc6-45e8-a892-dc6f2a564287"), "Ivana Baquero, Ariadna Gil, Sergi López", "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", "Guillermo del Toro", "Fantasy", "Spanish", "Spain", "https://i.pinimg.com/564x/0d/e1/d9/0de1d966d8bc5bd1867a7572fa87651f.jpg", "Pan's Labyrinth", "https://youtu.be/gpEh4O8Hb5Y?si=yjrHygCStaxnXElN", "B15", 118 },
                    { new Guid("b164e08a-d1c1-471c-bf5a-eec3c300244b"), "Anthony Gonzalez, Gael García Bernal, Benjamin Bratt", "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead.", "Lee Unkrich", "Animation", "English", "USA", "https://i.pinimg.com/564x/7a/6d/c4/7a6dc4222a7bd3037d9f7146314e3bc7.jpg", "Coco", "https://youtu.be/awzWdtCezDo?si=pTPm98sUcGuNg10o", "AA", 105 },
                    { new Guid("d2dd8262-4670-42e8-882a-8d2cfc797c42"), "Liam Neeson, Ralph Fiennes, Ben Kingsley", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce.", "Steven Spielberg", "Biography", "English", "USA", "https://i.pinimg.com/564x/58/7a/2a/587a2a1dbb33437d4c48811e020c4ec8.jpg", "Schindler's List", "https://youtu.be/7q-ETFeMxwI?si=A2edRplN3wnRQHgv", "C", 195 },
                    { new Guid("f93b1a5f-18e6-4871-b655-a3d454c89f55"), "Marlon Brando, Al Pacino, James Caan", "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", "Francis Ford Coppola", "Crime", "English", "USA", "https://i.pinimg.com/564x/1d/fa/6c/1dfa6ce2aca118aeddd66249d425c575.jpg", "The Godfather", "https://youtu.be/iOyQx7MXaz0?si=QQicWt7JaNHnLHOB", "B15", 175 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("02070507-b97f-49e5-9e17-e3517bce8745"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("0c7fbe2b-f20d-4c23-8b8d-7b6580a21d34"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("1f5a7d87-ed57-4513-b83e-9190113c9407"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("32d9080d-51a5-48d3-912c-5fa0e363f854"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("7a84ec21-b6a6-4fb7-84e9-411a4a41fc6d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("93128e3d-c28d-4be8-8f2c-d87145c3f3b1"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("a2fc8ed0-cbc6-45e8-a892-dc6f2a564287"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("b164e08a-d1c1-471c-bf5a-eec3c300244b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("d2dd8262-4670-42e8-882a-8d2cfc797c42"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("f93b1a5f-18e6-4871-b655-a3d454c89f55"));

            migrationBuilder.DropColumn(
                name: "Trailer",
                table: "Films");

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Cast", "Description", "Director", "Genre", "Language", "Origincountry", "PosterImage", "Title", "classification", "duration" },
                values: new object[,]
                {
                    { new Guid("0020a7da-22cb-44ac-ae4a-b46747683ef4"), "Song Kang-ho, Lee Sun-kyun, Cho Yeo-jeong", "A poor family schemes to become employed by a wealthy family.", "Bong Joon-ho", "Thriller", "English", "South Korea", "https://i.pinimg.com/564x/a9/7d/26/a97d26449214bb756c75b4ed88d7b06e.jpg", "Parasite", "B15", 132 },
                    { new Guid("22c49b34-d7ae-477e-9685-4a77f58de2e8"), "John Travolta, Uma Thurman, Samuel L. Jackson", "The lives of two mob hitmen, a boxer, and a pair of bandits intertwine in four tales of violence.", "Quentin Tarantino", "Crime", "English", "USA", "https://i.pinimg.com/564x/e4/05/0b/e4050b92335cde4a3b5ae340fc8c5ee3.jpg", "Pulp Fiction", "C", 154 },
                    { new Guid("2a062749-99de-4390-a140-1feafcc682dc"), "Audrey Tautou, Mathieu Kassovitz, Rufus", "Amélie is an innocent and naive girl in Paris with her own sense of justice.", "Jean-Pierre Jeunet", "Romantic Comedy", "French", "France", "https://i.pinimg.com/564x/d8/9e/ac/d89eac7350c0c7d61b8ca8b22863c398.jpg", "Amélie", "AA", 122 },
                    { new Guid("2c019fb3-bf0d-41b8-8d68-15e3e8c0d97d"), "Anthony Gonzalez, Gael García Bernal, Benjamin Bratt", "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead.", "Lee Unkrich", "Animation", "English", "USA", "https://i.pinimg.com/564x/7a/6d/c4/7a6dc4222a7bd3037d9f7146314e3bc7.jpg", "Coco", "AA", 105 },
                    { new Guid("38a77cb7-1188-4030-bba3-07c8e2157d1b"), "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", "A thief who steals corporate secrets through the use of dream-sharing technology.", "Christopher Nolan", "Science Fiction", "English", "USA", "https://i.pinimg.com/564x/43/9a/1c/439a1c4583a953c26b63d08a1d832f53.jpg", "Inception", "B", 148 },
                    { new Guid("46d71754-8612-4e53-bda5-aad242ca633a"), "Marlon Brando, Al Pacino, James Caan", "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", "Francis Ford Coppola", "Crime", "English", "USA", "https://i.pinimg.com/564x/1d/fa/6c/1dfa6ce2aca118aeddd66249d425c575.jpg", "The Godfather", "B15", 175 },
                    { new Guid("a5f837cd-e598-44eb-bbe0-d87c9494ac5c"), "Ivana Baquero, Ariadna Gil, Sergi López", "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", "Guillermo del Toro", "Fantasy", "Spanish", "Spain", "https://i.pinimg.com/564x/0d/e1/d9/0de1d966d8bc5bd1867a7572fa87651f.jpg", "Pan's Labyrinth", "B15", 118 },
                    { new Guid("bd3e052f-fc64-4004-8c06-53cb256eb1f9"), "Rumi Hiiragi, Miyu Irino, Mari Natsuki", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits.", "Hayao Miyazaki", "Animation", "English", "Japan", "https://i.pinimg.com/736x/93/6b/c2/936bc2c8a46385dddd69ecaa1fe1d2d5.jpg", "Spirited Away", "A", 125 },
                    { new Guid("be645d21-cd92-444c-9b6b-d1757dc6ad18"), "Christian Bale, Heath Ledger, Aaron Eckhart", "Batman begins his fight against crime in Gotham.", "Christopher Nolan", "Action", "English", "USA", "https://i.pinimg.com/564x/ea/a2/6e/eaa26e2c3bfa234c3cdd3c4d9fabad35.jpg", "The Dark Knight", "B", 152 },
                    { new Guid("ff464041-d0fd-4b06-9616-34e08071d5e3"), "Liam Neeson, Ralph Fiennes, Ben Kingsley", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce.", "Steven Spielberg", "Biography", "English", "USA", "https://i.pinimg.com/564x/58/7a/2a/587a2a1dbb33437d4c48811e020c4ec8.jpg", "Schindler's List", "C", 195 }
                });
        }
    }
}
