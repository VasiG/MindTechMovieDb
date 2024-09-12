using Microsoft.EntityFrameworkCore;

namespace MindTechMovieDbProject.Infrastructure
{
    public class MovieContext : DbContext
    {

        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }

    }
}
