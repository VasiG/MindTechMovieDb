using Newtonsoft.Json;

namespace MindTechMovieDbProject.Infrastructure.Responses
{
    public class BiographyResponse
    {
        [JsonProperty("adult")]
        public bool? Adult { get; set; }
        [JsonProperty("also_known_as")]
        public string[]? KnownAs { get; set; }
        [JsonProperty("biography")]
        public string? Biography { get; set; }
        [JsonProperty("birthday")]
        public DateTime? Birthday { get; set; }
        [JsonProperty("deathday")]
        public string? Deathday { get; set; }
        [JsonProperty("gender")]
        public string? gender { get; set; }
        [JsonProperty("homepage")]
        public string? Homepage { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("imdb_id")]
        public string? ImdbId { get; set; }
        [JsonProperty("known_for_department")]
        public string? KnownFor { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("place_of_birth")]
        public string? PlaceOfBirth { get; set; }
        [JsonProperty("popularity")]
        public string? Popularity { get; set; }
        [JsonProperty("profile_path")]
        public string? ProfilePath { get; set; }
    }
}
