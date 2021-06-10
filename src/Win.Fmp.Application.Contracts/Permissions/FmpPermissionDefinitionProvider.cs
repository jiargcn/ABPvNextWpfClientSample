using Win.Fmp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Win.Fmp.Permissions
{
    public class FmpPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FmpPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FmpPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FmpResource>(name);
        }
    }
}
