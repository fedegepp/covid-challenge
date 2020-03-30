using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CovidChallenge.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(CovidChallengeHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class CovidChallengeConsoleApiClientModule : AbpModule
    {
        
    }
}
