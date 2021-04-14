using Laison.Lapis.Identity.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Validation;

namespace Laison.Lapis.Identity.Application.Contracts
{
    public class RoleCreateOrUpdateDtoBase : ExtensibleObject
    {
        [Required]
        [DynamicStringLength(typeof(RoleConsts), nameof(RoleConsts.MaxNameLength))]
        public string Name { get; set; }


        protected RoleCreateOrUpdateDtoBase() : base(false)
        {
            
        }
    }
}