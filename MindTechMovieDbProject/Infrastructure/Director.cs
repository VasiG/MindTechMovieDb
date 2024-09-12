namespace MindTechMovieDbProject.Infrastructure
{
    public class Director
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TmdbId { get; set; }
        public string? Biography { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
