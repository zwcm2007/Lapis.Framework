using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laison.Lapis.Prepayment.Application.Contracts
{
    public interface ITradeDetailAppService
    {
        Task<List<RegisterTradeDto>> GetRegisterTradeDetails();

        Task<List<RechargeTradeDto>> GetRechargeTradeDetails();
    }
}
