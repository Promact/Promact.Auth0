using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Promact.Auth0;

[Dependency(ReplaceServices = true)]
public class Auth0BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Auth0";
}
