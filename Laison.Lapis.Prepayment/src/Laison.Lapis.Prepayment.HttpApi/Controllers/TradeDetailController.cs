using Laison.Lapis.Prepayment.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.Prepayment.HttpApi
{
    [RemoteService]
    [Route("api/prepayment/trade-detail")]
    public class TradeDetailController : PrepaymentControllerBase, ITradeDetailAppService
    {
        private readonly ICustomerAppService _accountAppService;

        public TradeDetailController(ICustomerAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }

        /// <summary>
        /// 获取开户交易记录
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("register")]
        public Task<RegisterTradeDto> GetRegisterTradeDetails()
        {
            throw new System.NotImplementedException();
        }
    }
}