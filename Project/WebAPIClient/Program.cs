using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static async Task<List<Repository>> ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);
            return repositories;
        }
        public static async Task Main(string[] args)
        {
            var repositories = await ProcessRepositories();
            foreach (var repo in repositories)
            {
                Console.WriteLine($"Name : {repo.Name}");
                Console.WriteLine($"Description : {repo.Description}");
                Console.WriteLine($"Github Url : {repo.GitHubHomeUrl}");
                Console.WriteLine($"Homepage : {repo.Homepage}");
                Console.WriteLine($"Watchers : {repo.Watchers}");
                Console.WriteLine($"LastPush : {repo.LastPush}");
                Console.WriteLine();
            }
        }
    }
}

