using Laison.Lapis.Prepayment.Application.Contracts;
using Laison.Lapis.Prepayment.Domain.Entities;
using Laison.Lapis.Prepayment.Domain.IRepositories;
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
            IRepository<RegisterTradeDetail, Guid> registerTradeDetailRepository
            )
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
            var account = new Account(GuidGenerator.Create(),
                input.MeterNo,
                input.Debt,
                true);

            await _accountRepository.InsertAsync(account);

            var customer = new Customer(account.Id,
                input.Customer.Name,
                input.Customer.Email,
                input.Customer.IdentityNo,
                input.Customer.Telephone);

            await _customerRepository.InsertAsync(customer);

            var tradeDetail = new RegisterTradeDetail(GuidGenerator.Create(),
                customer.Id,
                CurrentUser.Id.Value,
                200);

            await _registerTradeDetailRepository.InsertAsync(tradeDetail);

            var accountDto = ObjectMapper.Map<Account, AccountDto>(account);

            accountDto.Customer = ObjectMapper.Map<Customer, CustomerDto>(customer);

            return accountDto;
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

        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task FrozenAccountAsync(FrozenAccountInput input)
        {
            throw new NotImplementedException();
        }
    }
}