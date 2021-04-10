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
        private readonly IRepository<RechargeTradeDetail, Guid> _purchageTradeDetailRepository;

        public AccountAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task CancelAccountAsync(CancelAccountInput input)
        {
            throw new NotImplementedException();
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

            var tradeDetail = new RegistrationTradeDetail(GuidGenerator.Create(),
                customer.Id,
                CurrentUser.Id.Value,
                new MoneyAmount(200, Currency.Dollar));

            _purchageTradeDetailRepository.InsertAsync(tradeDetail);

            return null; ;
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