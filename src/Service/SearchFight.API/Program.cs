using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SearchFight.API.Application.Data;
using SearchFight.Infrastructure.EFCore;
using System;

namespace SearchFight.API
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = CreateHostBuilder(args).Build();

      using (var scope = host.Services.CreateScope())
      {
        var services = scope.ServiceProvider;
        try
        {
          var context = services.GetRequiredService<SearchFightDbContext>();
          SearchFightContextSeed.Initialize(context);
        } catch (Exception ex)
        {
          var logger = services.GetRequiredService<ILogger<Program>>();
          logger.LogError(ex, "An error occurred creating the DB.");
        }
      }

      host.Run();

    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureWebHostDefaults(webBuilder => {
              webBuilder.UseStartup<Startup>();
            });
  }
}
