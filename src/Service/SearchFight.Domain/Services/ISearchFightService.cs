using SearchFight.Domain.Models;
using System.Threading.Tasks;

namespace SearchFight.Domain.Services
{
  public interface ISearchFightService
  {
    Task<SearchFightResult> Fight(string[] programmingLanguages);

  }
}
