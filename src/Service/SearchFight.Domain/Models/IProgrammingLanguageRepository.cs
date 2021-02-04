namespace SearchFight.Domain.Models
{
  public interface IProgrammingLanguageRepository
  {
    ProgrammingLanguage GetProgrammingLanguageByKeywordAsync(string keyword);
  }
}
