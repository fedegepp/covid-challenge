using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CovidChallenge.Data
{
    /* This is used if database provider does't define
     * ICovidChallengeDbSchemaMigrator implementation.
     */
    public class NullCovidChallengeDbSchemaMigrator : ICovidChallengeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}