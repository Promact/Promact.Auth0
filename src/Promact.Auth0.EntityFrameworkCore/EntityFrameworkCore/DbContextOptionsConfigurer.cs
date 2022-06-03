using Microsoft.EntityFrameworkCore;

namespace Promact.Auth0.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<Auth0DbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for Auth0DbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
