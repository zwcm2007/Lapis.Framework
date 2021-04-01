using System;
using System.ComponentModel.DataAnnotations;

namespace Laison.Lapis.Account.Application.Contracts
{
    public class ResetPasswordDto
    {
        public Guid UserId { get; set; }

        //[Required]
        //public string ResetToken { get; set; }

        [Required]
        //[DisableAuditing]
        public string Password { get; set; }
    }
}