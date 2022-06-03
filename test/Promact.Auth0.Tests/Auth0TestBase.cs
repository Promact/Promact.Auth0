using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Promact.Auth0.EntityFrameworkCore;
using Promact.Auth0.Tests.TestDatas;

namespace Promact.Auth0.Tests
{
    public class Auth0TestBase : AbpIntegratedTestBase<Auth0TestModule>
    {
        public Auth0TestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<Auth0DbContext> action)
        {
            using (var context = LocalIocManager.Resolve<Auth0DbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<Auth0DbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<Auth0DbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<Auth0DbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<Auth0DbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<Auth0DbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<Auth0DbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
