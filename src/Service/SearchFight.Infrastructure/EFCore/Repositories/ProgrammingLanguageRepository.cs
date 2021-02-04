using Microsoft.EntityFrameworkCore;
using SearchFight.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFight.Infrastructure.EFCore.Repositories
{
  public class ProgrammingLanguageRepository : IProgrammingLanguageRepository
  {
    private readonly SearchFightDbContext _context;

    public ProgrammingLanguageRepository(SearchFightDbContext context)
    {
      _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public ProgrammingLanguage GetProgrammingLanguageByKeywordAsync(string keyword)
    {
      var list = _context.ProgrammingLanguages.ToList();
      
      foreach (var pl in list)
      {
        var keywords = pl.Keywords.Split(",");
        if(keywords.Contains(keyword))
        {
          return pl;
        }
      }

      return null;
    }
  }
}
