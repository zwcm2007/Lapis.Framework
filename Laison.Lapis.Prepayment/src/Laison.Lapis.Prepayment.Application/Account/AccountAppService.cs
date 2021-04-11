using Laison.Lapis.Prepayment.Application.Contracts;
using Laison.Lapis.Prepayment.Domain.Entities;
using Laison.Lapis.Prepayment.Domain.IRepositories;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Prepayment.Application
{
    /// <summary>
    /// 账户应用服务
    /// </summary>
    public class AccountAppService : PrepaymentAppServiceBase, IAccountAppService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IRepository<RechargeTradeDetail, Guid> _rechargeTradeDetailRepository;
        private readonly IRepository<RegisterTradeDetail, Guid> _registerTradeDetailRepository;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="accountRepository"></param>
        /// <param name="rechargeTradeDetailRepository"></param>
        /// <param name="registerTradeDetailRepository"></param>
        public AccountAppService(
            IAccountRepository accountRepository,
            IRepository<RechargeTradeDetail, Guid> rechargeTradeDetailRepository,
            IRepository<RegisterTradeDetail, Guid> registerTradeDetailRepository
            )
        {
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
                input.MakeCard,
                input.Remark);

            account.Customer.SetCustomer(
                input.Customer.Name,
                input.Customer.Email,
                input.Customer.IdentityNo,
                input.Customer.Telephone);

            account.Customer.Address.SetAddress(
                input.Customer.Address.Province,
                input.Customer.Address.City,
                input.Customer.Address.Town,
                input.Customer.Address.Village
                );

            await _accountRepository.InsertAsync(account);

            var tradeDetail = new RegisterTradeDetail(GuidGenerator.Create(),
                account.Id,
                CurrentUser.Id.Value,
                200);

            await _registerTradeDetailRepository.InsertAsync(tradeDetail);

            return ObjectMapper.Map<Account, AccountDto>(account);
        }

        /// <summary>
        /// 销户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task CancelAccountAsync(CancelAccountInput input)
        {
            var account = await _accountRepository.FindAsync(input.Id);
            if (account == null)
            {
                throw new UserFriendlyException($"账号不存在[{nameof(input.Id)}]！");
            }
            account.Cancel();
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
        /// 冻结
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task FrozenAccountAsync(FrozenAccountInput input)
        {
            throw new NotImplementedException();
        }
    }
}