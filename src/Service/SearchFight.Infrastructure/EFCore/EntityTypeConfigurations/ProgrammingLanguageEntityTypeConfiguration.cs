using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchFight.Domain.Models;

namespace SearchFight.Infrastructure.EFCore.EntityTypeConfigurations
{
  public class ProgrammingLanguageEntityTypeConfiguration : IEntityTypeConfiguration<ProgrammingLanguage>
  {
    public void Configure(EntityTypeBuilder<ProgrammingLanguage> builder)
    {
      builder.HasKey(e => e.Name);
    }
  }
}
