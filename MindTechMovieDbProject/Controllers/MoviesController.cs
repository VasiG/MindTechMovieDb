using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MindTechMovieDbProject.Infrastructure;

namespace MindTechMovieDbProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieContext movieContext;

        public MoviesController(MovieContext context)
        {
            movieContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {

            var movies = await movieContext.Movies.ToListAsync();
            return Ok(movies);
        }
    }
}
