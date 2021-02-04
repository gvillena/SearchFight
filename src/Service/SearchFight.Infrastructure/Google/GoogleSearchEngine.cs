using SearchFight.Domain.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SearchFight.Infrastructure.SearchEngines
{
  public class GoogleSearchEngine : ICustomSearchEngine
  {
    private const string GOOGLE_API_KEY = "AIzaSyADxqHa5-dVbVtiKWGbg56bw57_zhKoBDk";
    private const string GOOGLE_CUSTOM_SEARCH_ENGINE_ID = "b82f67273087c2c0c";
    private readonly HttpClient httpClient;

    public GoogleSearchEngine()
    {
      httpClient = new HttpClient();
      httpClient.BaseAddress = new Uri("https://www.googleapis.com");
    }

    public async Task<int> GetNumberOfSearchResults(ProgrammingLanguage programmingLanguage)
    {
      var query = $"customsearch/v1?key={GOOGLE_API_KEY}&cx={GOOGLE_CUSTOM_SEARCH_ENGINE_ID}&q={programmingLanguage.Name}";

      var response = await httpClient.GetStringAsync(query);

      return 0;
    }
  }
}
