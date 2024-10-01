using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Galaxi.Movie.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("00f5294e-b165-4851-b5cf-7487f047d250"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("116a23ce-afd5-4738-91bb-e4f3f7da6453"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("5785b4b7-8fe4-49fa-bd19-39e770b463b3"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("6a2250e0-5eef-4e36-9055-2e9aaae3e39b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("828c9ca0-687a-4ec9-a4b1-5730071cbe19"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("a44240d1-a5a4-426f-8059-2b8bf154693d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("b6226872-2cc7-4fb7-b3c5-5aaf88397182"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("b98b7fd3-767e-4d0b-83c6-6f67053ac074"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("fc1484aa-c69e-482c-85a9-f158c71e5e25"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: new Guid("fc43f07a-01cb-43af-b6a8-be5851e37643"));

            migrationBuilder.AlterColumn<string>(
                name: "classification",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "classification",
                table: "Films",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Language",
                table: "Films",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Cast", "Description", "Director", "Genre", "Language", "Origincountry", "PosterImage", "Title", "classification", "duration" },
                values: new object[,]
                {
                    { new Guid("00f5294e-b165-4851-b5cf-7487f047d250"), "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", "A thief who steals corporate secrets through the use of dream-sharing technology.", "Christopher Nolan", "Science Fiction", 0, "USA", "inception.jpg", "Inception", 2, 148 },
                    { new Guid("116a23ce-afd5-4738-91bb-e4f3f7da6453"), "Christian Bale, Heath Ledger, Aaron Eckhart", "Batman begins his fight against crime in Gotham.", "Christopher Nolan", "Action", 0, "USA", "darkknight.jpg", "The Dark Knight", 2, 152 },
                    { new Guid("5785b4b7-8fe4-49fa-bd19-39e770b463b3"), "Liam Neeson, Ralph Fiennes, Ben Kingsley", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce.", "Steven Spielberg", "Biography", 0, "USA", "schindlerslist.jpg", "Schindler's List", 4, 195 },
                    { new Guid("6a2250e0-5eef-4e36-9055-2e9aaae3e39b"), "Marlon Brando, Al Pacino, James Caan", "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", "Francis Ford Coppola", "Crime", 0, "USA", "godfather.jpg", "The Godfather", 3, 175 },
                    { new Guid("828c9ca0-687a-4ec9-a4b1-5730071cbe19"), "Audrey Tautou, Mathieu Kassovitz, Rufus", "Amélie is an innocent and naive girl in Paris with her own sense of justice.", "Jean-Pierre Jeunet", "Romantic Comedy", 2, "France", "amelie.jpg", "Amélie", 0, 122 },
                    { new Guid("a44240d1-a5a4-426f-8059-2b8bf154693d"), "John Travolta, Uma Thurman, Samuel L. Jackson", "The lives of two mob hitmen, a boxer, and a pair of bandits intertwine in four tales of violence.", "Quentin Tarantino", "Crime", 0, "USA", "pulpfiction.jpg", "Pulp Fiction", 4, 154 },
                    { new Guid("b6226872-2cc7-4fb7-b3c5-5aaf88397182"), "Rumi Hiiragi, Miyu Irino, Mari Natsuki", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits.", "Hayao Miyazaki", "Animation", 0, "Japan", "spiritedaway.jpg", "Spirited Away", 1, 125 },
                    { new Guid("b98b7fd3-767e-4d0b-83c6-6f67053ac074"), "Ivana Baquero, Ariadna Gil, Sergi López", "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", "Guillermo del Toro", "Fantasy", 1, "Spain", "panslabyrinth.jpg", "Pan's Labyrinth", 3, 118 },
                    { new Guid("fc1484aa-c69e-482c-85a9-f158c71e5e25"), "Anthony Gonzalez, Gael García Bernal, Benjamin Bratt", "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead.", "Lee Unkrich", "Animation", 0, "USA", "coco.jpg", "Coco", 0, 105 },
                    { new Guid("fc43f07a-01cb-43af-b6a8-be5851e37643"), "Song Kang-ho, Lee Sun-kyun, Cho Yeo-jeong", "A poor family schemes to become employed by a wealthy family.", "Bong Joon-ho", "Thriller", 0, "South Korea", "parasite.jpg", "Parasite", 3, 132 }
                });
        }
    }
}
