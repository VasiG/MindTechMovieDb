using MindTechMovieDbProject.Infrastructure;

namespace MindTechMovieDbProject.Services
{
    public class MovieService
    {
        private readonly MovieContext context;
        private readonly TMDbApiService tmdbService;
        public MovieService(MovieContext dbContext, TMDbApiService service)
        {
            this.context = dbContext;
            this.tmdbService = service;
        }

        public async Task UpdateMovies()
        {
            for (int i = 1; i <= 11; i++)
            {
                var movies = await tmdbService.GetTopRatedMovies(i);

                foreach (var movie in movies)
                {
                    var director = await tmdbService.GetDirector(movie.TmdbId);

                    var movieEntity = new Movie
                    {
                        Title = movie.Title,
                        Genres = string.Join(",", movie.Genres),
                        ReleaseDate = movie.ReleaseDate,
                        Overview = movie.Overview,
                        PosterUrl = movie.PosterUrl,
                        TmdbId = movie.TmdbId,
                        TmdbVoteAverage = movie.VoteAverage,
                        TmdbVoteCount = movie.VoteCount,
                        TmdbUrl = $"https://www.themoviedb.org/movie/{movie.TmdbId}-" + movie.Title.Replace(" ", "-"),
                        DirectorName = director.Name,
                        DirectorBio = director.Biography,
                        DirectorId = director.Id,
                        DirectorBirth = director.Birthday,
                    };

                    context.Movies.Add(movieEntity);
                }
                await context.SaveChangesAsync();
            }
        }

    }
}
