using SearchFight.Domain.Models;
using SearchFight.Domain.Services;
using SearchFight.Infrastructure.SearchEngines;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SearchFight.API.Services.SearchFightService
{
  public class SearchFightService : ISearchFightService
  {
    private readonly IProgrammingLanguageRepository _repository;
    private readonly GoogleSearchEngine _googleSearchEngine;


    public SearchFightService(IProgrammingLanguageRepository repository, GoogleSearchEngine googleSearchEngine)
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
      _googleSearchEngine = googleSearchEngine ?? throw new ArgumentNullException(nameof(googleSearchEngine));
    }

    public async Task<SearchFightResult> Fight(string[] programmingLanguages)
    {
      var _programingLanguages = new List<ProgrammingLanguage>();

      foreach (var keyword in programmingLanguages)
      {
        var pl = _repository.GetProgrammingLanguageByKeywordAsync(keyword);

        if (pl == null)
        {
          return null;
        }

        var n = await _googleSearchEngine.GetNumberOfSearchResults(pl);

      }


      return null;


    }
  }
}
