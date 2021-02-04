using Autofac;
using SearchFight.API.Services.SearchFightService;
using SearchFight.Domain.Services;

namespace SearchFight.API.Application.Modules
{
  public class ApplicationModule : Autofac.Module
  {

    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<SearchFightService>()
         .As<ISearchFightService>()
         .InstancePerLifetimeScope();
    }


  }
}
