using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Galaxi.Movie.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addClassification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PosterImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Director = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cast = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Origincountry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Language = table.Column<int>(type: "int", nullable: false),
                    classification = table.Column<int>(type: "int", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
