using Abp.AspNetCore.Mvc.Controllers;

namespace Promact.Auth0.Web.Controllers
{
    public abstract class Auth0ControllerBase: AbpController
    {
        protected Auth0ControllerBase()
        {
            LocalizationSourceName = Auth0Consts.LocalizationSourceName;
        }
    }
}