using Abp.Application.Services;

namespace Promact.Auth0
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class Auth0AppServiceBase : ApplicationService
    {
        protected Auth0AppServiceBase()
        {
            LocalizationSourceName = Auth0Consts.LocalizationSourceName;
        }
    }
}