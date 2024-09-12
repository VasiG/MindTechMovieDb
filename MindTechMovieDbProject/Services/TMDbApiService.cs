using Microsoft.EntityFrameworkCore.Storage.Json;
using MindTechMovieDbProject.Infrastructure.Responses;
using Newtonsoft.Json;
using System.IO;

namespace MindTechMovieDbProject.Services
{
    public class TMDbApiService
    {
        private readonly HttpClient httpClient;
        private readonly string apiKey = "359c412e72a55bc597abb258b101d786";

        public TMDbApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<MovieResponse>> GetTopRatedMovies(int page)
        {
            var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/movie/top_rated?api_key={apiKey}&page={page}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var movies = JsonConvert.DeserializeObject<TopRatedMoviesResponse>(json);
                return movies.Results;
            }
            return null;
        }

        public async Task<BiographyResponse> GetDirector(int movieId)
        {
            var response = await httpClient.GetAsync($" https://api.themoviedb.org/3/movie/{movieId}/credits?api_key={apiKey}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var credits = JsonConvert.DeserializeObject<CreditsResponse>(json);
                var director = credits.Crew.FirstOrDefault(c => c.Job == "Director");

                if (director != null)
                {
                    var biographyResponse = await httpClient.GetAsync($"https://api.themoviedb.org/3/person/{director.Id}?api_key={apiKey}");
                    if (biographyResponse.IsSuccessStatusCode)
                    {
                        var bioJson = await biographyResponse.Content.ReadAsStringAsync();
                        var directorDetails = JsonConvert.DeserializeObject<BiographyResponse>(bioJson);
                        return directorDetails;
                    }
                }
            }
            return null;
        }
    }

}
