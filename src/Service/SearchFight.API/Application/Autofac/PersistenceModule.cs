using Autofac;
using SearchFight.Domain.Models;
using SearchFight.Infrastructure.EFCore.Repositories;

namespace SearchFight.API.Application.Modules
{
  public class PersistenceModule : Autofac.Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<ProgrammingLanguageRepository>()
          .As<IProgrammingLanguageRepository>()
          .InstancePerLifetimeScope();
    }
  }
}
