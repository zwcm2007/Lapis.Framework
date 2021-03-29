using JetBrains.Annotations;
using System.Security.Claims;

namespace Laison.Lapis.Shared
{
    public interface ICurrentUser
    {
        bool IsAuthenticated { get; }

        [CanBeNull]
        int? Id { get; }

        [CanBeNull]
        string UserName { get; }

        [CanBeNull]
        string PhoneNumber { get; }

        [CanBeNull]
        string Email { get; }

        //Guid? TenantId { get; }

        string AccountId { get; }

        [NotNull]
        string[] Roles { get; }

        [CanBeNull]
        Claim FindClaim(string claimType);

        [NotNull]
        Claim[] FindClaims(string claimType);

        [NotNull]
        Claim[] GetAllClaims();

        bool IsInRole(string roleName);
    }
}