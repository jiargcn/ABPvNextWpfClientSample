using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Win.Fmp.Pages
{
    public class Index_Tests : FmpWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
