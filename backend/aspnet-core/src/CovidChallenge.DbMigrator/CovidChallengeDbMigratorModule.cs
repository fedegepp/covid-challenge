using CovidChallenge.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CovidChallenge.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CovidChallengeEntityFrameworkCoreDbMigrationsModule),
        typeof(CovidChallengeApplicationContractsModule)
        )]
    public class CovidChallengeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
