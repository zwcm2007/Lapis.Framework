using Laison.Lapis.Identity.Domain.Entities;

namespace Laison.Lapis.Account.Domain
{
    public static class UserExtension
    {
        public static bool CheckPassword2(this User user, string currentPassword)
        {
            return user.Password == currentPassword;
        }
    }
}