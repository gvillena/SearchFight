using Microsoft.EntityFrameworkCore;
using SearchFight.Domain.Models;
using SearchFight.Infrastructure.EFCore.EntityTypeConfigurations;

namespace SearchFight.Infrastructure.EFCore
{
  public class SearchFightDbContext : DbContext
  {
    public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

    public SearchFightDbContext(DbContextOptions<SearchFightDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=SearchFightDb.db");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new ProgrammingLanguageEntityTypeConfiguration());
    }

  }
}
