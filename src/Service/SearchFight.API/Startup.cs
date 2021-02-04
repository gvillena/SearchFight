using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SearchFight.API.Application.DependencyInjection;
using SearchFight.API.Application.Modules;

namespace SearchFight.API
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddCustomDbContext();
      services.AddControllers();
    }

    public void ConfigureContainer(ContainerBuilder builder)
    {
      builder.RegisterModule(new ApplicationModule());
      builder.RegisterModule(new PersistenceModule());
      builder.RegisterModule(new SearchEngineModule());
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseEndpoints(endpoints => {
        endpoints.MapControllers();
      });
    }
  }
}
