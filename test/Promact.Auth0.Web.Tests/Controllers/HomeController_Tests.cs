using System.Threading.Tasks;
using Promact.Auth0.Web.Controllers;
using Shouldly;
using Xunit;

namespace Promact.Auth0.Web.Tests.Controllers
{
    public class HomeController_Tests: Auth0WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
