using Laison.Lapis.Prepayment.Application.Contracts;
using Laison.Lapis.Prepayment.Domain.Entities;
using Laison.Lapis.Prepayment.Domain.IRepositories;
using Laison.Lapis.Prepayment.Domain.ValueObjects;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Prepayment.Application
{
    /// <summary>
    /// 账户应用服务
    /// </summary>
    public class AccountAppService : PrepaymentAppServiceBase, IAccountAppService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IRepository<RechargeTradeDetail, Guid> _rechargeTradeDetailRepository;
        private readonly IRepository<RegisterTradeDetail, Guid> _registerTradeDetailRepository;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="customerRepository"></param>
        /// <param name="accountRepository"></param>
        /// <param name="rechargeTradeDetailRepository"></param>
        /// <param name="registerTradeDetailRepository"></param>
        public AccountAppService(
            ICustomerRepository customerRepository,
            IAccountRepository accountRepository,
            IRepository<RechargeTradeDetail, Guid> rechargeTradeDetailRepository,
            IRepository<RegisterTradeDetail, Guid> registerTradeDetailRepository)
        {
            _customerRepository = customerRepository;
            _accountRepository = accountRepository;
            _rechargeTradeDetailRepository = rechargeTradeDetailRepository;
            _registerTradeDetailRepository = registerTradeDetailRepository;
        }

        /// <summary>
        /// 开户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<AccountDto> CreateAccountAsync(CreateAccountInput input)
        {
            var account = new Account(GuidGenerator.Create(), input.MeterNo, input.Debt);

            await _accountRepository.InsertAsync(account);

            var customer = new Customer(GuidGenerator.Create(), account.Id,
                input.Customer.Name,
                input.Customer.Email,
                input.Customer.IdentityNo);

            await _customerRepository.InsertAsync(customer);

            var tradeDetail = new RegisterTradeDetail(GuidGenerator.Create(),
                customer.Id,
                CurrentUser.Id.Value,
                new MoneyAmount(200, Currency.Dollar));

            await _registerTradeDetailRepository.InsertAsync(tradeDetail);

            return null; ;
        }

        /// <summary>
        /// 销户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task CancelAccountAsync(CancelAccountInput input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 充值(购水)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task RechargeAccountAsync(RechargeAccountInput input)
        {
            throw new NotImplementedException();
        }
    }
}