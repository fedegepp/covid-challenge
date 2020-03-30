using Volo.Abp.Settings;

namespace CovidChallenge.Settings
{
    public class CovidChallengeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CovidChallengeSettings.MySetting1));
        }
    }
}
