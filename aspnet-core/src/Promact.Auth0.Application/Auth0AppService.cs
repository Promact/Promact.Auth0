using System;
using System.Collections.Generic;
using System.Text;
using Promact.Auth0.Localization;
using Volo.Abp.Application.Services;

namespace Promact.Auth0;

/* Inherit your application services from this class.
 */
public abstract class Auth0AppService : ApplicationService
{
    protected Auth0AppService()
    {
        LocalizationResource = typeof(Auth0Resource);
    }
}
