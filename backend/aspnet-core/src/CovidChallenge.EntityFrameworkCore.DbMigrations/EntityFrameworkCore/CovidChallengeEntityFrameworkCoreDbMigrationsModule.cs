using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace CovidChallenge.EntityFrameworkCore
{
    [DependsOn(
        typeof(CovidChallengeEntityFrameworkCoreModule)
        )]
    public class CovidChallengeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CovidChallengeMigrationsDbContext>();
        }
    }
}
