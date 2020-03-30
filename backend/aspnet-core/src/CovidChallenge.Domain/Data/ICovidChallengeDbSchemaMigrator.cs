using System.Threading.Tasks;

namespace CovidChallenge.Data
{
    public interface ICovidChallengeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
