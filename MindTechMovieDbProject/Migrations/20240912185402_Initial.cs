using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MindTechMovieDbProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Genres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TmdbId = table.Column<int>(type: "int", nullable: false),
                    TmdbVoteAverage = table.Column<double>(type: "float", nullable: false),
                    TmdbVoteCount = table.Column<int>(type: "int", nullable: false),
                    TmdbUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorId = table.Column<int>(type: "int", nullable: true),
                    DirectorBio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorBirth = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
