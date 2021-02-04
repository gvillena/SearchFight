using Autofac;
using SearchFight.Infrastructure.SearchEngines;

namespace SearchFight.API.Application.Modules
{
  public class SearchEngineModule : Autofac.Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<GoogleSearchEngine>()
          .InstancePerLifetimeScope();
    }
  }
}
