using Laison.Lapis.Identity.Domain.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Auditing;
using Volo.Abp.Validation;

namespace Laison.Lapis.Identity.Application.Contracts
{
    /// <summary>
    /// 修改密码输入
    /// </summary>
    public class ChangePasswordInput : IValidatableObject
    {
        [Required]
        [DisableAuditing]
        [DynamicStringLength(typeof(UserConsts), nameof(UserConsts.MaxPasswordLength))]
        public string CurrentPassword { get; set; }

        [Required]
        [DisableAuditing]
        [DynamicStringLength(typeof(UserConsts), nameof(UserConsts.MaxPasswordLength))]
        public string NewPassword { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CurrentPassword == NewPassword)
            {
                yield return new ValidationResult("原密码和新密码不能相同");
            }
        }
    }
}