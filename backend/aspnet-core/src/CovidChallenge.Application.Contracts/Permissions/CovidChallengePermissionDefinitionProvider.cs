using CovidChallenge.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CovidChallenge.Permissions
{
    public class CovidChallengePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CovidChallengePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CovidChallengePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CovidChallengeResource>(name);
        }
    }
}
