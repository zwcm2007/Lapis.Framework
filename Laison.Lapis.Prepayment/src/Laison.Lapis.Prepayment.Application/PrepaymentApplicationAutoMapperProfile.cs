using AutoMapper;
using Laison.Lapis.Prepayment.Application.Contracts;
using Laison.Lapis.Prepayment.Domain.Entities;

namespace Laison.Lapis.Prepayment.Application
{
    public class PrepaymentApplicationAutoMapperProfile : Profile
    {
        public PrepaymentApplicationAutoMapperProfile()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}