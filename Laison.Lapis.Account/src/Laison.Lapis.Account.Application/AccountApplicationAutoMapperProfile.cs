using AutoMapper;
using Laison.Lapis.Account.Application.Contracts;
using Laison.Lapis.Identity.Domain.Entities;

namespace Laison.Lapis.Account.Application
{
    public class AccountApplicationAutoMapperProfile : Profile
    {
        public AccountApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<User, UserDto>();
        }
    }
}