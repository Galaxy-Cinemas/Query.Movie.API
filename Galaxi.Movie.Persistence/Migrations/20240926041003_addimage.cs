using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Galaxi.Movie.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("0680bd74-b6fb-4ca6-9878-f676c7d51936"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("182cdb5d-9ed2-400b-922c-f9e0521dde3e"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("3b8f4f14-b7cb-4d54-805a-ed7358c0858f"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("8291ffb2-6747-470a-865f-dac56801e01c"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("84af8500-2591-40b4-aa26-6247dcd574d1"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("8d3885cd-9840-4b14-893b-89a280e92833"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("a6276a11-dadf-46f7-b513-de1bff52d11d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("b77dacc2-d72d-4258-a8ad-01e97f4ad219"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("f63a6702-af52-4f0a-8bce-aa84cf86b180"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("f97c04eb-38cd-4540-995a-e0f90a2ef5f2"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Films",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Films",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Cast", "Description", "Director", "Genre", "Language", "Origincountry", "PosterImage", "Title", "classification", "duration" },
                values: new object[,]
                {
                    { new Guid("0680bd74-b6fb-4ca6-9878-f676c7d51936"), "Anthony Gonzalez, Gael García Bernal, Benjamin Bratt", "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead.", "Lee Unkrich", "Animation", "English", "USA", "coco.jpg", "Coco", "AA", 105 },
                    { new Guid("182cdb5d-9ed2-400b-922c-f9e0521dde3e"), "Christian Bale, Heath Ledger, Aaron Eckhart", "Batman begins his fight against crime in Gotham.", "Christopher Nolan", "Action", "English", "USA", "darkknight.jpg", "The Dark Knight", "B", 152 },
                    { new Guid("3b8f4f14-b7cb-4d54-805a-ed7358c0858f"), "Liam Neeson, Ralph Fiennes, Ben Kingsley", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce.", "Steven Spielberg", "Biography", "English", "USA", "schindlerslist.jpg", "Schindler's List", "C", 195 },
                    { new Guid("8291ffb2-6747-470a-865f-dac56801e01c"), "Ivana Baquero, Ariadna Gil, Sergi López", "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", "Guillermo del Toro", "Fantasy", "Spanish", "Spain", "panslabyrinth.jpg", "Pan's Labyrinth", "B15", 118 },
                    { new Guid("84af8500-2591-40b4-aa26-6247dcd574d1"), "Marlon Brando, Al Pacino, James Caan", "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", "Francis Ford Coppola", "Crime", "English", "USA", "godfather.jpg", "The Godfather", "B15", 175 },
                    { new Guid("8d3885cd-9840-4b14-893b-89a280e92833"), "Song Kang-ho, Lee Sun-kyun, Cho Yeo-jeong", "A poor family schemes to become employed by a wealthy family.", "Bong Joon-ho", "Thriller", "English", "South Korea", "parasite.jpg", "Parasite", "B15", 132 },
                    { new Guid("a6276a11-dadf-46f7-b513-de1bff52d11d"), "John Travolta, Uma Thurman, Samuel L. Jackson", "The lives of two mob hitmen, a boxer, and a pair of bandits intertwine in four tales of violence.", "Quentin Tarantino", "Crime", "English", "USA", "pulpfiction.jpg", "Pulp Fiction", "C", 154 },
                    { new Guid("b77dacc2-d72d-4258-a8ad-01e97f4ad219"), "Rumi Hiiragi, Miyu Irino, Mari Natsuki", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits.", "Hayao Miyazaki", "Animation", "English", "Japan", "spiritedaway.jpg", "Spirited Away", "A", 125 },
                    { new Guid("f63a6702-af52-4f0a-8bce-aa84cf86b180"), "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", "A thief who steals corporate secrets through the use of dream-sharing technology.", "Christopher Nolan", "Science Fiction", "English", "USA", "inception.jpg", "Inception", "B", 148 },
                    { new Guid("f97c04eb-38cd-4540-995a-e0f90a2ef5f2"), "Audrey Tautou, Mathieu Kassovitz, Rufus", "Amélie is an innocent and naive girl in Paris with her own sense of justice.", "Jean-Pierre Jeunet", "Romantic Comedy", "French", "France", "amelie.jpg", "Amélie", "AA", 122 }
                });
        }
    }
}
