using System.Threading.Tasks;
using Laison.Lapis.Account.Application.Contracts;
using Shouldly;
using Xunit;

namespace Laison.Lapis.Account.Samples
{
    public class SampleAppService_Tests : AccountApplicationTestBase
    {
        private readonly IOrderAppService _orderAppService;

        public SampleAppService_Tests()
        {
            _orderAppService = GetRequiredService<IOrderAppService>();
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
