using Newtonsoft.Json;

namespace MindTechMovieDbProject.Infrastructure
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Length { get; set; }
        public string? Genres { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Overview { get; set; }
        public string? PosterUrl { get; set; }
        public int TmdbId { get; set; }
        public double TmdbVoteAverage { get; set; }
        public int TmdbVoteCount { get; set; }
        public string? TmdbUrl { get; set; }
        public string? DirectorName { get; set; }
        public int? DirectorId { get; set; }
        public string? DirectorBio { get; set; }
        public DateTime? DirectorBirth { get; set; }
    }
}
