using AutoMapper;
using Laison.Lapis.Prepayment.Application.Contracts;
using Laison.Lapis.Prepayment.Domain.Entities;
using Laison.Lapis.Prepayment.Domain.ValueObjects;

namespace Laison.Lapis.Prepayment.Application
{
    public class PrepaymentApplicationAutoMapperProfile : Profile
    {
        public PrepaymentApplicationAutoMapperProfile()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Address, AddressDto>();
        }
    }
}