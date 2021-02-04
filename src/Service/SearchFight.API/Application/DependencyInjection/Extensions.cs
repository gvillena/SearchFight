using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SearchFight.Infrastructure.EFCore;

namespace SearchFight.API.Application.DependencyInjection
{
  public static class Extensions
  {

    public static IServiceCollection AddCustomDbContext(this IServiceCollection services)
    {
      services.AddDbContext<SearchFightDbContext>(options => options.UseSqlite("Data Source=SearchFightDb.db"));

      return services;
    }

  }
}
