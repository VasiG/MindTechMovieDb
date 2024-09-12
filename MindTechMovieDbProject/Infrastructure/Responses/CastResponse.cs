using Newtonsoft.Json;

namespace MindTechMovieDbProject.Infrastructure.Responses
{
    public class CastResponse
    {
        public class CrewResponse
        {
            [JsonProperty("adult")]
            public string? Adult { get; set; }
            [JsonProperty("gender")]
            public string? Gender { get; set; }
            [JsonProperty("id")]
            public string? Id { get; set; }
            [JsonProperty("known_for_department")]
            public string? KnownForDepartment { get; set; }
            [JsonProperty("name")]
            public string? Name { get; set; }
            [JsonProperty("original_name")]
            public string? OriginalName { get; set; }
            [JsonProperty("popularity")]
            public string? Popularity { get; set; }
            [JsonProperty("profile_path")]
            public string? ProfilePath { get; set; }
            [JsonProperty("cast_id")]
            public string? CastId { get; set; }
            [JsonProperty("character")]
            public string? Character { get; set; }
            [JsonProperty("credit_id")]
            public string? CreditId { get; set; }
            [JsonProperty("order")]
            public string? Order { get; set; }

        }
    }
}
