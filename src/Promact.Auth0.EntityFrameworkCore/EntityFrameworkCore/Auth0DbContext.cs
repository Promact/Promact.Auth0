using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Promact.Auth0.EntityFrameworkCore
{
    public class Auth0DbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public Auth0DbContext(DbContextOptions<Auth0DbContext> options) 
            : base(options)
        {

        }
    }
}
