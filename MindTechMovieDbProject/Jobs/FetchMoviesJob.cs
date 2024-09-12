using MindTechMovieDbProject.Services;
using Quartz;

namespace MindTechMovieDbProject.Jobs
{
    public class FetchMoviesJob : IJob
    {
        private readonly MovieService movieService;

        public FetchMoviesJob(MovieService movieService)
        {
            this.movieService = movieService;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            await movieService.UpdateMovies();
        }
    }
}
