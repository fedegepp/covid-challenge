using Volo.Abp.Modularity;

namespace CovidChallenge
{
    [DependsOn(
        typeof(CovidChallengeApplicationModule),
        typeof(CovidChallengeDomainTestModule)
        )]
    public class CovidChallengeApplicationTestModule : AbpModule
    {

    }
}