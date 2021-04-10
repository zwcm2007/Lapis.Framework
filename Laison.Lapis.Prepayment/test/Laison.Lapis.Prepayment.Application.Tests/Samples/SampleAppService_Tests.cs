using System.Threading.Tasks;
using Laison.Lapis.Prepayment.Application.Contracts;
using Shouldly;
using Xunit;

namespace Laison.Lapis.Prepayment.Samples
{
    public class SampleAppService_Tests : PrepaymentApplicationTestBase
    {
        private readonly IAccountAppService _orderAppService;

        public SampleAppService_Tests()
        {
            _orderAppService = GetRequiredService<IAccountAppService>();
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
