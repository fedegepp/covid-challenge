using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CovidChallenge.Data;
using Volo.Abp.DependencyInjection;

namespace CovidChallenge.EntityFrameworkCore
{
    public class EntityFrameworkCoreCovidChallengeDbSchemaMigrator
        : ICovidChallengeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCovidChallengeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CovidChallengeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CovidChallengeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}