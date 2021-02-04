using SearchFight.Domain.Models;
using SearchFight.Infrastructure.EFCore;
using System.Linq;

namespace SearchFight.API.Application.Data
{
  public static class SearchFightContextSeed
  {
    public static void Initialize(SearchFightDbContext context)
    {
      context.Database.EnsureCreated();

      if (context.ProgrammingLanguages.Any())
      {
        return;
      }

      var programmingLanguages = new ProgrammingLanguage[]
      {
        new ProgrammingLanguage() { Name = "C#",
          Keywords = "c#, csharp, c-sharp" },

        new ProgrammingLanguage() { Name = "Visual Basic",
          Keywords = "visualbasic, visual-basic, vb" },

        new ProgrammingLanguage() { Name = "Javascript",
          Keywords = "javascript, java-script, js" },

        new ProgrammingLanguage() { Name = "java",
          Keywords = "java" }
      };

      context.ProgrammingLanguages.AddRange(programmingLanguages);
      context.SaveChanges();
    }
  }
}
