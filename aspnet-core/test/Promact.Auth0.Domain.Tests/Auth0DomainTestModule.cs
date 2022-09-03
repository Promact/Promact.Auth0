using Promact.Auth0.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Promact.Auth0;

[DependsOn(
    typeof(Auth0EntityFrameworkCoreTestModule)
    )]
public class Auth0DomainTestModule : AbpModule
{

}
