using Promact.Auth0.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Promact.Auth0.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Auth0Controller : AbpControllerBase
{
    protected Auth0Controller()
    {
        LocalizationResource = typeof(Auth0Resource);
    }
}
