using Laison.Lapis.Identity.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Auditing;
using Volo.Abp.Validation;

namespace Laison.Lapis.Identity.Application.Contracts
{
    public class ChangePasswordInput
    {
        [Required]
        [DisableAuditing]
        [DynamicStringLength(typeof(UserConsts), nameof(UserConsts.MaxPasswordLength))]
        public string CurrentPassword { get; set; }

        [Required]
        [DisableAuditing]
        [DynamicStringLength(typeof(UserConsts), nameof(UserConsts.MaxPasswordLength))]
        public string NewPassword { get; set; }
    }
}