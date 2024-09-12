using Newtonsoft.Json;

namespace MindTechMovieDbProject.Infrastructure.Responses
{
    public class MovieResponse
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }
        [JsonProperty("backdrop_path")]
        public string BackDropPath { get; set; }
        [JsonProperty("original_title")]
        public string OrigTitle { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("genre_ids")]
        public string[] Genres { get; set; }
        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
        [JsonProperty("overview")]
        public string Overview { get; set; }
        [JsonProperty("popularity")]
        public string Popularity { get; set; }
        [JsonProperty("poster_path")]
        public string PosterUrl { get; set; }
        [JsonProperty("id")]
        public int TmdbId { get; set; }
        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
        [JsonProperty("original_language")]
        public string OrigLang { get; set; }
        [JsonProperty("video")]
        public bool Video { get; set; }
    }
}
