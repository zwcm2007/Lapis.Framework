using System.Threading.Tasks;
using Laison.Lapis.Identity.Application.Contracts;
using Shouldly;
using Xunit;

namespace Laison.Lapis.Identity.Samples
{
    public class SampleAppService_Tests : IdentityApplicationTestBase
    {
        private readonly IUserAppService _orderAppService;

        public SampleAppService_Tests()
        {
            _orderAppService = GetRequiredService<IUserAppService>();
        }

        //[Fact]
        //public async Task GetAsync()
        //{
        //    var result = await _sampleAppService.GetAsync();
        //    result.Value.ShouldBe(42);
        //}

        //[Fact]
        //public async Task GetAuthorizedAsync()
        //{
        //    var result = await _sampleAppService.GetAuthorizedAsync();
        //    result.Value.ShouldBe(42);
        //}
    }
}
