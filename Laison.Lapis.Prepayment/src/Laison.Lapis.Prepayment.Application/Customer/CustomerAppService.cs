using Laison.Lapis.Prepayment.Application.Contracts;
using Laison.Lapis.Prepayment.Domain.Entities;
using Laison.Lapis.Prepayment.Domain.IRepositories;
using System.Threading.Tasks;

namespace Laison.Lapis.Prepayment.Application
{
    /// <summary>
    /// 客户应用服务
    /// </summary>
    public class CustomerAppService : PrepaymentAppServiceBase, ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository orderRepository)
        {
            _customerRepository = orderRepository;
        }

        public async Task<AccountDto> CreateAsync(CreateAccountInput input)
        {
            var account = new Account(GuidGenerator.Create(), input.MeterNo, "", "");

            await _accountRepository.InsertAsync(account);

            var customer = new Customer(GuidGenerator.Create(), account.Id,
                input.Customer.Name,
                input.Customer.Email,
                input.Customer.IdentityNo);

            await _customerRepository.InsertAsync(customer);
        }
    }
}