using CovidChallenge.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CovidChallenge
{
    [DependsOn(
        typeof(CovidChallengeEntityFrameworkCoreTestModule)
        )]
    public class CovidChallengeDomainTestModule : AbpModule
    {

    }
}