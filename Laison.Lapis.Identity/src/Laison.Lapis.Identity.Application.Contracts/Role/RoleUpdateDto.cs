using Laison.Lapis.Identity.Application.Contracts;
using Volo.Abp.Domain.Entities;

namespace Volo.Abp.Identity
{
    public class RoleUpdateDto : RoleCreateOrUpdateDtoBase, IHasConcurrencyStamp
    {
        public string ConcurrencyStamp { get; set; }
    }
}