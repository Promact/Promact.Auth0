using Abp.AspNetCore.Mvc.Views;

namespace Promact.Auth0.Web.Views
{
    public abstract class Auth0RazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected Auth0RazorPage()
        {
            LocalizationSourceName = Auth0Consts.LocalizationSourceName;
        }
    }
}
