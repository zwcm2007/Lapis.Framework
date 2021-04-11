using Laison.Lapis.Prepayment.Application.Contracts;
using Laison.Lapis.Prepayment.Domain.Entities;
using Laison.Lapis.Prepayment.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace Laison.Lapis.Prepayment.Application
{
    /// <summary>
    /// 交易明细应用服务
    /// </summary>
    public class TradeDetailAppService : PrepaymentAppServiceBase, ITradeDetailAppService
    {
        private readonly IRepository<RechargeTradeDetail, Guid> _purchaseTradeDetailRepository;

        public TradeDetailAppService(IRepository<RechargeTradeDetail, Guid> purchaseTradeDetailRepository)
        {
            _purchaseTradeDetailRepository = purchaseTradeDetailRepository;
        }

        public Task<List<RechargeTradeDto>> GetRechargeTradeDetails()
        {
            throw new NotImplementedException();
        }

        public Task<List<RegisterTradeDto>> GetRegisterTradeDetails()
        {
            throw new NotImplementedException();
        }
    }
}