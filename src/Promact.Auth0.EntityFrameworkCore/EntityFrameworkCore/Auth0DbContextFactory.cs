using Promact.Auth0.Configuration;
using Promact.Auth0.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Promact.Auth0.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class Auth0DbContextFactory : IDesignTimeDbContextFactory<Auth0DbContext>
    {
        public Auth0DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Auth0DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(Auth0Consts.ConnectionStringName)
            );

            return new Auth0DbContext(builder.Options);
        }
    }
}