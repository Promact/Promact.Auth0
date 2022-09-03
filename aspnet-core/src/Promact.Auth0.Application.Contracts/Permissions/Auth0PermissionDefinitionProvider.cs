using Promact.Auth0.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Promact.Auth0.Permissions;

public class Auth0PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Auth0Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Auth0Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Auth0Resource>(name);
    }
}
