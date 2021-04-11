using System.Threading.Tasks;
using Laison.Lapis.SettingManagement.Application.Contracts;
using Shouldly;
using Xunit;

namespace Laison.Lapis.SettingManagement.Samples
{
    public class SampleAppService_Tests : SettingManagementApplicationTestBase
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
