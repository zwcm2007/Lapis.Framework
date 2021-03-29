using JetBrains.Annotations;
using System;
using System.Diagnostics;

namespace Laison.Lapis.Shared
{
    public static class CurrentUserExtensions
    {
        [CanBeNull]
        public static string FindClaimValue(this ICurrentUser currentUser, string claimType)
        {
            return currentUser.FindClaim(claimType)?.Value;
        }

        public static T FindClaimValue<T>(this ICurrentUser currentUser, string claimType)
            where T : struct
        {
            var value = currentUser.FindClaimValue(claimType);
            if (value == null)
            {
                return default;
            }

            return value.To<T>();
        }
    }
}