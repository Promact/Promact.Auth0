using Volo.Abp.Modularity;

namespace Promact.Auth0;

[DependsOn(
    typeof(Auth0ApplicationModule),
    typeof(Auth0DomainTestModule)
    )]
public class Auth0ApplicationTestModule : AbpModule
{

}
