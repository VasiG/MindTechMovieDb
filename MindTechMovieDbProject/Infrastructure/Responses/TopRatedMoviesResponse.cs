using Newtonsoft.Json;

namespace MindTechMovieDbProject.Infrastructure.Responses
{
    internal class TopRatedMoviesResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("results")]
        public List<MovieResponse>? Results { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }
}