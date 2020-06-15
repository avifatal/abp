using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Eyez.Backend.Pages
{
    public class Index_Tests : BackendWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
