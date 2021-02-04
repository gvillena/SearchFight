using System.Threading.Tasks;

namespace SearchFight.Domain.Models
{
  public interface ICustomSearchEngine
  {
    Task<int> GetNumberOfSearchResults(ProgrammingLanguage programmingLanguage);
  }
}
