
using System.Net.Http.Json;

namespace BlazorSample.Client
{
    public class HttpArticleService(HttpClient http) : IArticleService
    {
        public Task<string[]> GetArticleTitles(int count) =>
            http.GetFromJsonAsync<string[]>($"values/{count}")!;
    }
}
