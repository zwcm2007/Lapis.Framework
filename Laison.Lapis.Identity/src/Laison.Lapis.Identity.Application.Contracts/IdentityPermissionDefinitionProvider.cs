using Laison.Lapis.Identity.Application.Contracts;
using Laison.Lapis.Identity.Domain.Shared;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyCompanyName.MyProjectName.Permissions
{
    public class IdentityPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(IdentityPermissions.GroupName, L("Permission:Identity"));
            
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<IdentityResource>(name);
        }
    }
}