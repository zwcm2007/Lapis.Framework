using Laison.Lapis.Prepayment.Application.Contracts;
using Laison.Lapis.Prepayment.Domain.Entities;
using Laison.Lapis.Prepayment.Domain.IRepositories;
using System.Threading.Tasks;

namespace Laison.Lapis.Prepayment.Application
{
    /// <summary>
    /// 账户应用服务
    /// </summary>
    public class AccountAppService : PrepaymentAppServiceBase, IAccountAppService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;

        public AccountAppService(ICustomerRepository orderRepository)
        {
            _customerRepository = orderRepository;
        }

        public async Task<AccountDto> CreateAccountAsync(CreateAccountInput input)
        {
            var account = new Account(GuidGenerator.Create(), input.MeterNo, input.Debt);

            await _accountRepository.InsertAsync(account);

            var customer = new Customer(GuidGenerator.Create(), account.Id,
                input.Customer.Name,
                input.Customer.Email,
                input.Customer.IdentityNo);

            await _customerRepository.InsertAsync(customer);

            return null; ;

        }


    }
}