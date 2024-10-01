using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Galaxi.Movie.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateRules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("005c30a9-e3ea-49af-8f72-a335c11488d1"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("1e963cde-fe0c-4448-b541-b81ec5fe04ec"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("335fe6f1-fd20-4bf6-97ce-47c7ba51d46f"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("4b4a0167-9ad1-438b-9982-59415943cc50"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("c8bd6cc4-0be1-4921-b2fa-831e0197ec29"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("d7d0587c-2125-408c-8c17-9a04b28c15c9"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("d93a8915-155a-4eb9-88c3-6573567a6a9c"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("e033037f-f006-4423-ad19-f338fd60adcd"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("f2b5f6f1-1562-4d32-90c7-a1551bd64265"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("f486d6ed-b405-426f-8ab3-25f424ac9f58"));

            migrationBuilder.AlterColumn<int>(
                name: "duration",
                table: "Films",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Films",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "duration",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Films",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Cast", "Description", "Director", "Genre", "Language", "Origincountry", "PosterImage", "Title", "classification", "duration" },
                values: new object[,]
                {
                    { new Guid("005c30a9-e3ea-49af-8f72-a335c11488d1"), "Anthony Gonzalez, Gael García Bernal, Benjamin Bratt", "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead.", "Lee Unkrich", "Animation", "English", "USA", "coco.jpg", "Coco", "AA", 105 },
                    { new Guid("1e963cde-fe0c-4448-b541-b81ec5fe04ec"), "Liam Neeson, Ralph Fiennes, Ben Kingsley", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce.", "Steven Spielberg", "Biography", "English", "USA", "schindlerslist.jpg", "Schindler's List", "C", 195 },
                    { new Guid("335fe6f1-fd20-4bf6-97ce-47c7ba51d46f"), "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", "A thief who steals corporate secrets through the use of dream-sharing technology.", "Christopher Nolan", "Science Fiction", "English", "USA", "inception.jpg", "Inception", "B", 148 },
                    { new Guid("4b4a0167-9ad1-438b-9982-59415943cc50"), "Rumi Hiiragi, Miyu Irino, Mari Natsuki", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits.", "Hayao Miyazaki", "Animation", "English", "Japan", "spiritedaway.jpg", "Spirited Away", "A", 125 },
                    { new Guid("c8bd6cc4-0be1-4921-b2fa-831e0197ec29"), "John Travolta, Uma Thurman, Samuel L. Jackson", "The lives of two mob hitmen, a boxer, and a pair of bandits intertwine in four tales of violence.", "Quentin Tarantino", "Crime", "English", "USA", "pulpfiction.jpg", "Pulp Fiction", "C", 154 },
                    { new Guid("d7d0587c-2125-408c-8c17-9a04b28c15c9"), "Marlon Brando, Al Pacino, James Caan", "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", "Francis Ford Coppola", "Crime", "English", "USA", "godfather.jpg", "The Godfather", "B15", 175 },
                    { new Guid("d93a8915-155a-4eb9-88c3-6573567a6a9c"), "Ivana Baquero, Ariadna Gil, Sergi López", "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", "Guillermo del Toro", "Fantasy", "Spanish", "Spain", "panslabyrinth.jpg", "Pan's Labyrinth", "B15", 118 },
                    { new Guid("e033037f-f006-4423-ad19-f338fd60adcd"), "Audrey Tautou, Mathieu Kassovitz, Rufus", "Amélie is an innocent and naive girl in Paris with her own sense of justice.", "Jean-Pierre Jeunet", "Romantic Comedy", "French", "France", "amelie.jpg", "Amélie", "AA", 122 },
                    { new Guid("f2b5f6f1-1562-4d32-90c7-a1551bd64265"), "Song Kang-ho, Lee Sun-kyun, Cho Yeo-jeong", "A poor family schemes to become employed by a wealthy family.", "Bong Joon-ho", "Thriller", "English", "South Korea", "parasite.jpg", "Parasite", "B15", 132 },
                    { new Guid("f486d6ed-b405-426f-8ab3-25f424ac9f58"), "Christian Bale, Heath Ledger, Aaron Eckhart", "Batman begins his fight against crime in Gotham.", "Christopher Nolan", "Action", "English", "USA", "darkknight.jpg", "The Dark Knight", "B", 152 }
                });
        }
    }
}
