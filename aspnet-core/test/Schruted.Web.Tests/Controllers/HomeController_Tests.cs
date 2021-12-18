using System.Threading.Tasks;
using Schruted.Models.TokenAuth;
using Schruted.Web.Controllers;
using Shouldly;
using Xunit;

namespace Schruted.Web.Tests.Controllers
{
    public class HomeController_Tests: SchrutedWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}