using Newtonsoft.Json;

namespace MindTechMovieDbProject.Infrastructure.Responses
{
    public class CreditsResponse
    {
        [JsonProperty("id")]
        public string? Id { get; set; }
        [JsonProperty("cast")]
        public ICollection<CastResponse>? Cast { get; set; }
        [JsonProperty("crew")]
        public ICollection<CrewResponse>? Crew { get; set; }
    }
}
